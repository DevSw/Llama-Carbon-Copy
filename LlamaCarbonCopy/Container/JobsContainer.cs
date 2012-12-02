using System;
using System.Collections.Generic;
using System.Text;

namespace LlamaCarbonCopy.Container {
	[Serializable]
	public class JobsContainer : Container {
		public List<JobContainer> Jobs;
		public JobsContainer() { Jobs = new List<JobContainer>(); }
		public JobsContainer(List<JobContainer> jobs) { Jobs = jobs;}
	}
}
