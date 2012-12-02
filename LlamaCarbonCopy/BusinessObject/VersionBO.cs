using System;
namespace LlamaCarbonCopy.BusinessObject{
	public class VersionBO {
		protected string version;
		public string Version {
			get { return version; }
			set { version = value; }
		}
		protected string programname;
		public string ProgramName {
			get { return programname; }
			set { programname = value; }
		}
		public VersionBO(){ this.Version = "1.2.8"; this.programname = "Llama Carbon Copy"; }
		public override string ToString(){ return this.programname + " v" + this.version; }
	}
}
