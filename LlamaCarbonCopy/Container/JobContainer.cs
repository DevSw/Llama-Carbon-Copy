using System;
using System.Collections.Generic;
using System.Text;

namespace LlamaCarbonCopy.Container {
	public class JobContainer : Container {
		public bool WatchSubDirectories;
		public string Name;
		public string SourceDirectory;
		public string DestinationDirectory;
		public JobContainer() { }
	}
}
