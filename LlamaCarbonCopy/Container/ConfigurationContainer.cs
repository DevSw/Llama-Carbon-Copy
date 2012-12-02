using System;
using System.Collections.Generic;
using System.Text;

namespace LlamaCarbonCopy.Container {
	[Serializable]
	public class ConfigurationContainer : Container{
		public int WaitTime;
		public bool AutoStart;
		public int MaxRetryCount;
		public ConfigurationContainer() { WaitTime = 3000; AutoStart = true; MaxRetryCount = 5; }
	}
}
