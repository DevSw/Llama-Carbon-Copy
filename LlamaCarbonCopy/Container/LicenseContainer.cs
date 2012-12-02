using System;
using System.Collections.Generic;
using System.Text;

namespace LlamaCarbonCopy.Container {
	[Serializable]
	public class LicenseContainer : Container {
		public int Days;
		public DateTime StartDate;
		public LicenseContainer() { Days = 14; StartDate = DateTime.Now; }
	}
}
