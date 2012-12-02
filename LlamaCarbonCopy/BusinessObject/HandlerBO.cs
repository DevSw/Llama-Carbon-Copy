using LlamaCarbonCopy.BusinessObject.Copier;
using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections;
using System.IO;
using System.Timers;

namespace LlamaCarbonCopy.BusinessObject {
	public class HandlerBO : BaseBO {
		private ICopier Copier;
		private System.Timers.Timer QTimer;
		public event EventHandler Finished;
		private int RetryCount = 0;
		protected WriteContainer wcontainer;
		public WriteContainer WContainer {
			get { return wcontainer; }
			set { wcontainer = value; }
		}	
		protected string fullpath;		
		public string Fullpath {
			get { return fullpath; }
			set { fullpath = value; }
		}		
		public HandlerBO() : base() {
			this.Copier = new SimpleCopy();
			ConfigurationBO cbo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			this.QTimer = new Timer(Convert.ToInt32(cbo.CContainer.WaitTime));
			this.QTimer.AutoReset = true;
			this.QTimer.Elapsed += new ElapsedEventHandler(this.Timer_Tick);
		}
		public HandlerBO(string fullpath, WriteContainer container) : this() {
			this.fullpath = fullpath;
			this.wcontainer = container;
		}

		public void ResetTimer() {
			this.QTimer.Stop();
			ConfigurationBO cbo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			this.QTimer.Interval = Convert.ToInt32(cbo.CContainer.WaitTime);
			this.QTimer.Start();
		}
		public void StartTimer() { this.QTimer.Start(); }
		public void StopTimer() { this.QTimer.Stop(); }

		private void Timer_Tick(object sender, System.Timers.ElapsedEventArgs args) {
			JobContainer jContainer = this.wcontainer.Container;
			string destination = SharedBO.CalculateDestination(
				jContainer.SourceDirectory, fullpath, jContainer.DestinationDirectory);// Path.Combine(jContainer.DestinationDirectory, Path.GetFileName(this.fullpath));
			try {
				if (DoneTrying()) {
					IReporter reporter = ReporterManager.GetReporter();
					reporter.AddReport(new ActionReportContainer(ActionType.Copy, ActionReportResult.Failed, "Attempted to copy file " + this.RetryCount + " times.", this.fullpath, destination));
					this.QTimer.Stop();
					this.OnFinished(EventArgs.Empty);
				}
				else {
					
					if( !File.Exists(this.fullpath)){
						if (wcontainer.ChangeType == WatcherChangeTypes.Renamed) {
							string relativeOldDir = SharedBO.CalculateDestination(
								wcontainer.OldFullPath, 
								jContainer.SourceDirectory, 
								jContainer.DestinationDirectory);
							Directory.Move(relativeOldDir, destination);
						}
						else {
							if (!Directory.Exists(destination)) 
								Directory.CreateDirectory(destination); 
						}
					
						this.QTimer.Stop();
						this.OnFinished(EventArgs.Empty);
					} else {
						this.Copier.Copy(this.fullpath, destination, true);
						this.QTimer.Stop();
						this.OnFinished(EventArgs.Empty);
					}
				}
			}
			catch (System.IO.FileNotFoundException) {
				IReporter reporter = ReporterManager.GetReporter();
				reporter.AddReport(new ActionReportContainer(ActionType.Copy, ActionReportResult.Failed, "File Not Found", this.fullpath, destination));
				this.QTimer.Stop();
				this.OnFinished(EventArgs.Empty);
			}
			catch (System.Exception ex) {
				IReporter reporter = ReporterManager.GetReporter();
				reporter.AddReport(new ActionReportContainer(ActionType.Copy, ActionReportResult.Failed, ex.ToString(), this.fullpath, destination));
				this.RetryCount++;
			}
		}
		private bool DoneTrying() {
			ConfigurationBO cbo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			ConfigurationContainer container = cbo.CContainer;
			return this.RetryCount > container.MaxRetryCount;
		}
		
		private void OnFinished(EventArgs e) {
			EventHandler ev = this.Finished;
			if (ev != null)
				this.Finished(this, e);
		}
	}
}
