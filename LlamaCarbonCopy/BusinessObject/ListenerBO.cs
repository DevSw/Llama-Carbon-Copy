using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections.Generic;
using System.IO;

namespace LlamaCarbonCopy.BusinessObject {
	public class ListenerBO : BaseBO {
		private Dictionary<JobContainer, FileSystemWatcher> Watchers;
		private Dictionary<string, HandlerBO> Handlers;
		private Dictionary<string, JobContainer> WatcherContainers;
		public bool Started;
		public event EventHandler StatusChanged;
		public void OnStatusChanged(EventArgs e) {
			EventHandler ev = StatusChanged;
			if (ev != null) ev(this, e);
		}
		public ListenerBO() : base() {
			this.Watchers = new Dictionary<JobContainer,FileSystemWatcher>();
			this.Handlers = new Dictionary<string,HandlerBO>();
			this.WatcherContainers = new Dictionary<string,JobContainer>();
		}

		public void StartListeners() {
			if (this.Started) return;			

			JobsBO jbo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));									
			foreach (JobContainer container in jbo.JContainer.Jobs) {
				if (container.SourceDirectory.Length > 0 && container.DestinationDirectory.Length > 0) {
					if (Directory.Exists(container.SourceDirectory) && Directory.Exists(container.DestinationDirectory)) {
						try {
							FileSystemWatcher watcher = new FileSystemWatcher(container.SourceDirectory);
							watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size |NotifyFilters.DirectoryName |NotifyFilters.CreationTime;
							watcher.IncludeSubdirectories = container.WatchSubDirectories; 
							watcher.Created += new FileSystemEventHandler(Watcher_Event);
							//watcher.Deleted += new FileSystemEventHandler(Watcher_Event);					
							watcher.Renamed += new RenamedEventHandler(Watcher_Renamed);
							watcher.Changed += new FileSystemEventHandler(Watcher_Event);
							watcher.EnableRaisingEvents = true;
							lock (this.Watchers) { Watchers.Add(container, watcher); }
							lock (this.WatcherContainers) { this.WatcherContainers.Add(container.SourceDirectory, container); }
						}
						catch (Exception ex) {
							IReporter reporter = ReporterManager.GetReporter();
							reporter.AddReport(new ActionReportContainer(ActionType.Notify, ActionReportResult.Noted, ex.ToString()));
						}
					}
					else {
						IReporter reporter = ReporterManager.GetReporter();
						reporter.AddReport(new ActionReportContainer(ActionType.Notify, ActionReportResult.Noted,
							"There was an error finding one or more of the two following directories:\n" +
							container.SourceDirectory + "\n" + container.DestinationDirectory));
					}
				}
			}
			this.Started = true;
			OnStatusChanged(EventArgs.Empty);
		}
		public void RestartListeners() {
			if (this.Started) {
				StopListeners();
				StartListeners();
			}
		}
		public void StopListeners() {
			lock (this.Watchers) {
				foreach (FileSystemWatcher fsw in this.Watchers.Values) {
					fsw.EnableRaisingEvents = false;
					fsw.Dispose();
				}
				this.Watchers = new Dictionary<JobContainer,FileSystemWatcher>();
				this.WatcherContainers = new Dictionary<string,JobContainer>();
			}
			this.Started = false;
			OnStatusChanged(EventArgs.Empty);
		}

		private void Watcher_Renamed(object sender, RenamedEventArgs args) {
			
			string dir = Path.GetDirectoryName(args.FullPath);
			if (WatcherChangeTypes.Renamed == args.ChangeType) {
				//at this point the renamed item could be a directory
				try {
					JobContainer container = AcquireJobContainerByDirectory(dir); //(JobContainer)this.WatcherContainers[dir];
					WriteContainer wcontainer = new WriteContainer(container.SourceDirectory, container);
					wcontainer.ChangeType = args.ChangeType;
					wcontainer.OldFullPath = args.OldFullPath;
					this.ProcessFile(args.FullPath, wcontainer);
				}
				catch (Exception ex) {
					IReporter reporter = ReporterManager.GetReporter();
					reporter.AddReport(new ActionReportContainer(ActionType.Notify, ActionReportResult.Noted, ex.ToString()));
				}
			}			
		}
		private void Watcher_Event(object sender, FileSystemEventArgs args) {
			
			string dir = Path.GetDirectoryName(args.FullPath);
			JobContainer container = AcquireJobContainerByDirectory(dir);// (JobContainer)this.WatcherContainers[dir];
			WriteContainer wcontainer = new WriteContainer(container.SourceDirectory, container);
			try {
				if (WatcherChangeTypes.Deleted != args.ChangeType) { this.ProcessFile(args.FullPath, wcontainer); }
				//TODO: Give users the option to copy a "delete" action
			}
			catch (Exception ex) {
				IReporter reporter = ReporterManager.GetReporter();
				reporter.AddReport(new ActionReportContainer(ActionType.Notify, ActionReportResult.Noted, ex.ToString()));
			}
			
		}

		private void ProcessFile(string fullpath, WriteContainer wcontainer) {
			lock (this.Handlers) {
				if (!this.Handlers.ContainsKey(fullpath)) {
					HandlerBO handler = new HandlerBO(fullpath, wcontainer);
					this.Handlers.Add(fullpath, handler);
					handler.Finished += new EventHandler(handler_Finished);
					handler.StartTimer();
				}
				else {
					HandlerBO handler = (HandlerBO)this.Handlers[fullpath];
					handler.ResetTimer();
				}
			}
		}

		private void handler_Finished(object sender, EventArgs e) { this.ReleaseHandler((HandlerBO)sender); }
		private void ReleaseHandler(HandlerBO handler) {
			lock (this.Handlers) {
				if (this.Handlers.ContainsKey(handler.Fullpath)) { this.Handlers.Remove(handler.Fullpath); }
			}
		}

		private JobContainer AcquireJobContainerByDirectory(string dir) {
			if (dir.Length == 0) return null;
			if (WatcherContainers.ContainsKey(dir)) return WatcherContainers[dir];
			else return AcquireJobContainerByDirectory(Path.GetDirectoryName(dir));
		}
	}
}
