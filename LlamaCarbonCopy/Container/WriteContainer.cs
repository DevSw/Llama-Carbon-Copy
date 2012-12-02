using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LlamaCarbonCopy.Container {
	public class WriteContainer : Container{
		public WriteContainer() { }
		public WriteContainer(string dir, JobContainer container) { dir = directory; Container = container; }
		public string directory;
		public JobContainer Container;
		public WatcherChangeTypes ChangeType;
		public string OldFullPath;
	}
}
