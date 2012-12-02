using LlamaCarbonCopy.BusinessObject.Copier;
using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace LlamaCarbonCopy.BusinessObject {
	public class SynchronizeBO : BaseBO {
		protected int SynchTotalFileCount;
		protected int SynchProgressCount;
		protected ICopier copier;
		protected IReporter reporter;
		public IReporter Reporter {
			get { return this.reporter; }
		}
		public event System.EventHandler FinishedSynch;
		protected void OnFinishedSynch(EventArgs args) {
			EventHandler ev = this.FinishedSynch;
			if (ev != null) ev(this, args);
		}
		public event SynchEventHandler Synchronized;
		protected void OnSynchronized(SynchEventHandlerArgs args) {
			SynchEventHandler ev = Synchronized;
			if (ev != null) ev(this, args);
		}
		public SynchronizeBO() {
			this.reporter = new SynchronizeReporter();
			this.copier = new SimpleCopy();
		}
		public SynchronizeBO(ICopier copier) : this() { this.copier = copier; }

		#region Synch All
		
		public void aMatchAll() { ThreadPool.QueueUserWorkItem(new WaitCallback(MatchAll), null); }
		public void MatchAll() {
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
			SynchProgressCount = 0;
			foreach (JobContainer container in bo.JContainer.Jobs)
				SynchTotalFileCount += countFiles(container.SourceDirectory, container.WatchSubDirectories);
			foreach (JobContainer container in bo.JContainer.Jobs) {
				SynchronizeDirectory(
					container.SourceDirectory,
					container.SourceDirectory,
					container.DestinationDirectory,
					container.WatchSubDirectories,
					true);
			}
			this.OnFinishedSynch(EventArgs.Empty);
		}
		public void aSynchronizeAll() {
			ThreadPool.QueueUserWorkItem(new WaitCallback(SynchronizeAll), null);
		}
		public void SynchronizeAll() {			
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
			SynchProgressCount = 0;
			foreach (JobContainer container in bo.JContainer.Jobs)
				SynchTotalFileCount += countFiles(container.SourceDirectory, container.WatchSubDirectories);			
			foreach (JobContainer container in bo.JContainer.Jobs) {
				SynchronizeDirectory(
					container.SourceDirectory, 
					container.SourceDirectory, 
					container.DestinationDirectory, 
					container.WatchSubDirectories,
					false);
			}
			this.OnFinishedSynch(EventArgs.Empty);
		}
		public void SynchronizeAll(object obj) { this.SynchronizeAll(); }
		public void MatchAll(object obj) { this.MatchAll(); }

		private int countFiles(string dir, bool includeSubfolders) {
			int count = Directory.GetFiles(dir).Length;
			if (includeSubfolders) {
				foreach (string subdir in Directory.GetDirectories(dir))
					count += countFiles(subdir, includeSubfolders);
			}
			return count;
		}

		#endregion

		#region Synch Dir
		public void aSynchronizeDirectory(string oDirectory) {
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));			
			List<JobContainer> selected = bo.JContainer.Jobs.FindAll( delegate(JobContainer j){
				return Path.GetDirectoryName(j.SourceDirectory).ToLower().CompareTo(oDirectory) == 0;				
			});
			foreach (JobContainer container in selected)
				this.aSynchronizeDirectory(oDirectory, oDirectory, container.DestinationDirectory, container.WatchSubDirectories, false);
			this.OnFinishedSynch(EventArgs.Empty);
		}
		public void aSynchronizeDirectory(string oBaseDir, string oDirectory, string cDirectory, bool includeSubfolders, bool delete) {
			//string[] arry = { oDirectory, cDirectory };
			SynchronizationArguments args = new SynchronizationArguments(
				oBaseDir,oDirectory, cDirectory, includeSubfolders, delete);
			ThreadPool.QueueUserWorkItem(new WaitCallback(SynchronizeDirectory), args);
		}
		public void SynchronizeDirectory(string oBaseDir, string oDirectory, string cDirectory, bool includeSubfolders, bool delete) {
			if (Directory.Exists(oDirectory)) {
				if (Directory.Exists(cDirectory)) {
					string[] oFiles = Directory.GetFiles(oDirectory);					
					foreach (string oFile in oFiles) {
						string file = Path.GetFileName(oFile);
						//string dir = Path.GetDirectoryName(oFile);
						string cFile = Path.Combine(cDirectory, file);
						if (!FilesExist(oFile, cFile) || !CompareFiles(oFile, cFile)) {
							Copy(oFile, cFile);
							OnSynchronized(new SynchEventHandlerArgs(SynchTotalFileCount, SynchProgressCount++, "Copied: " + oFile));
						}
					}
					if (delete) {
						try {
							List<string> sOFiles = new List<string>();
							foreach (string f in oFiles) sOFiles.Add(Path.Combine(cDirectory, Path.GetFileName(f)));
							string[] cFiles = Directory.GetFiles(cDirectory);
							foreach (string cFile in cFiles) if (!sOFiles.Contains(cFile)) File.Delete(cFile);

							List<string> cSubDirectories = new List<string>(Directory.GetDirectories(cDirectory));
							List<string> oSubDirectories = new List<string>();
							foreach (string s in Directory.GetDirectories(oDirectory)) oSubDirectories.Add(Path.GetFileName(s));
							foreach (string dir in cSubDirectories) if (!oSubDirectories.Contains(Path.GetFileName(dir))) Directory.Delete(dir, true);
						}
						catch (UnauthorizedAccessException ) { }
						catch (Exception ) { }
					}
					if (includeSubfolders) {
						foreach (string dir in Directory.GetDirectories(oDirectory)) {
							SynchronizeDirectory(
								oBaseDir,
								dir,
								SharedBO.CalculateDestination(oDirectory, dir, cDirectory),
								includeSubfolders,
								delete);
						}
					}
				}
				else {
					Directory.CreateDirectory(cDirectory);
					string[] oFiles = Directory.GetFiles(oDirectory);
					foreach (string oFile in oFiles) {
						Copy(oFile, Path.Combine(cDirectory, Path.GetFileName(oFile)));
						OnSynchronized(new SynchEventHandlerArgs(SynchTotalFileCount, SynchProgressCount++, "Copied: " + oFile));
					}
					if (includeSubfolders) {
						foreach (string dir in Directory.GetDirectories(oDirectory)) {
							SynchronizeDirectory(
								oBaseDir,
								dir,
								SharedBO.CalculateDestination(oDirectory, dir, cDirectory),
								includeSubfolders,
								false);
						}
					}
				}
			}
			else {
				DirectoryExistsFailure(oDirectory);
			}
		}
		private void SynchronizeDirectory(object obj) {
			SynchronizationArguments args = (SynchronizationArguments)obj;
			SynchTotalFileCount = countFiles(args.oDirectory, args.includeSubfolders);			
			this.SynchronizeDirectory(args.oBaseDirectory, args.oDirectory, args.cDirectory, args.includeSubfolders, args.delete);
			OnFinishedSynch(EventArgs.Empty);
		}
		#endregion

		#region Synch File
		public void aSynchronizeFile(string oFile, string cFile) {
			string[] arry = { oFile, cFile };
			ThreadPool.QueueUserWorkItem(new WaitCallback(SynchronizeFile), arry);
		}
		public void aSynchronizeFile(string oFile) {
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
			List<JobContainer> selected = bo.JContainer.Jobs.FindAll(delegate(JobContainer j) {
				return Path.GetDirectoryName(j.SourceDirectory).ToLower().CompareTo(Path.GetDirectoryName(oFile)) == 0;
			});
			foreach (JobContainer container in selected)
				this.aSynchronizeFile(oFile, Path.Combine(Path.GetDirectoryName(container.DestinationDirectory), Path.GetFileName(oFile)));
			this.OnFinishedSynch(EventArgs.Empty);
		}
		public void SynchronizeFile(string oFile, string cFile) {
			if (Directory.Exists(Path.GetDirectoryName(oFile))) {
				if (!Directory.Exists(Path.GetDirectoryName(cFile))) Directory.CreateDirectory(Path.GetDirectoryName(cFile));
				Copy(oFile, cFile);
			}
			else { DirectoryExistsFailure(oFile); }
		}
		private void SynchronizeFile(object obj) {
			string[] files = (string[])obj;
			this.SynchronizeFile(files[0], files[1]);
		}
		#endregion

		private void Copy(string oFile, string cFile) {
			try {
				this.copier.Copy(oFile, cFile, true);
				this.reporter.AddReport(
					new ActionReportContainer(ActionType.Copy, ActionReportResult.Succeeded, "Copy succeeded", oFile, cFile));
			}
			catch (Exception ex) {
				IReporter reporter = ReporterManager.GetReporter();
				ActionReportContainer container = new ActionReportContainer(
					ActionType.Copy, ActionReportResult.Failed, ex.ToString(), oFile, cFile);
				reporter.AddReport(container);
				this.reporter.AddReport(container);
			}
		}
		private void DirectoryExistsFailure(string oFile) {
			IReporter reporter = ReporterManager.GetReporter();
			ActionReportContainer container = new ActionReportContainer(ActionType.Copy, ActionReportResult.Failed,
				"The source directory " + Path.GetDirectoryName(oFile) + " does not exist.  It cannot be watched.");
			reporter.AddReport(container);
			this.reporter.AddReport(container);
		}
		private bool FilesExist(string original, string copy) { return File.Exists(original) && File.Exists(copy); }
		private bool CompareFiles(string original, string copy) {
			FileInfo originalInfo = new FileInfo(original);
			FileInfo copyInfo = new FileInfo(copy);
			return
				originalInfo.Length == copyInfo.Length &&
				originalInfo.Name == copyInfo.Name &&
				originalInfo.LastWriteTime <= copyInfo.LastWriteTime;
		}
	}
	public delegate void SynchEventHandler(object sender, SynchEventHandlerArgs args);
	public class SynchEventHandlerArgs : EventArgs {
		public int total;
		public int completed;
		public string action;
		public SynchEventHandlerArgs() { }
		public SynchEventHandlerArgs(int total, int completed, string action) {
			this.total = total;
			this.completed = completed;
			this.action = action;
		}
	}
	public class SynchronizationArguments {
		public string oBaseDirectory;
		public string oDirectory;
		public string cDirectory;
		public bool includeSubfolders;
		public bool delete;
		public SynchronizationArguments(string obasedir, string odir, string cdir, bool include, bool delete) {
			oBaseDirectory = obasedir;
			oDirectory = odir;
			cDirectory = cdir;
			includeSubfolders = include;
			this.delete = delete;
		}
	}
}
