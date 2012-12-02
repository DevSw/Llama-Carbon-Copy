using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using LlamaCarbonCopy.Container;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.BusinessObject.Reporter;
namespace LlamaCarbonCopy.BusinessObject {
	public class JobsBO : BaseBO{
		private JobsContainer jContainer;
		public JobsContainer JContainer {
			get { if (jContainer == null) LoadJobs(); return jContainer; }
		}
		public void Add(JobContainer container) {
			if (jContainer == null) LoadJobs();
			jContainer.Jobs.Add(container);
		}
		public void Delete(JobContainer container) {
			if (jContainer == null) LoadJobs();
			jContainer.Jobs.Remove(container);
		}
		
		private void LoadJobs(){
			try {
				string jobsfile = SharedBO.GetJobsFile();
				//jContainer = MoreXmlSerializer.Deserialize<JobsContainer>(jobsfile);
				jContainer = ReadJobs(jobsfile);
				if (jContainer == null) jContainer = new JobsContainer();
			}
			catch {
				jContainer = new JobsContainer();
			}	
		}		
		public void Save() {
			try {
				string jobsfile = SharedBO.GetJobsFile();
				//MoreXmlSerializer.Serialize<JobsContainer>(jContainer, jobsfile);
				WriteJobs(jContainer, jobsfile);
				ListenerBO bo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
				bo.RestartListeners();
			}
			catch {/*(Exception e){ 
				System.Windows.Forms.MessageBox.Show(e.ToString());*/
			}	
		}
		public JobContainer FindByName(string name) {
			return jContainer.Jobs.Find(delegate(JobContainer j) { return j.Name.CompareTo(name) == 0; });
		}

		private void WriteJobs(JobsContainer container, string file) {
			StringBuilder sb = new StringBuilder();
			sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
			sb.Append("<JobsContainer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\n");
			sb.Append("<Jobs>\n");
			foreach (JobContainer jobcontainer in jContainer.Jobs) {
				sb.AppendLine("<JobContainer>");
				sb.AppendFormat("<WatchSubDirectories>{0}</WatchSubDirectories>\n", jobcontainer.WatchSubDirectories);
				sb.AppendFormat("<Name>{0}</Name>\n", jobcontainer.Name);
				sb.AppendFormat("<SourceDirectory>{0}</SourceDirectory>\n", jobcontainer.SourceDirectory);
				sb.AppendFormat("<DestinationDirectory>{0}</DestinationDirectory>\n", jobcontainer.DestinationDirectory);
				sb.AppendLine("</JobContainer>");
			}
			sb.Append("</Jobs>\n");
			sb.Append("</JobsContainer>\n");

			System.IO.StreamWriter sw = null;
			try {
				sw = new System.IO.StreamWriter(file);
				sw.Write(sb.ToString());
			}
			catch {}
			finally { if (sw != null) sw.Close(); }
		}
		private JobsContainer ReadJobs(string file) {
			JobsContainer container = new JobsContainer();
			XmlTextReader reader = null;
			try {
				reader = new XmlTextReader(new StreamReader(file));
				JobContainer job = null;
				bool valuesAdded = false;
				while (!reader.EOF) {
					reader.Read();
					if (reader.IsStartElement()) {
						if (reader.Name == "JobContainer") {
							if (job != null) container.Jobs.Add(job);
							job = new JobContainer();
						}
						else if (reader.Name == "WatchSubDirectories") {
							reader.MoveToContent();
							reader.Read();
							job.WatchSubDirectories = bool.Parse(reader.Value);
							valuesAdded = true;
						}
						else if (reader.Name == "SourceDirectory") {
							reader.MoveToContent();
							reader.Read();
							job.SourceDirectory = reader.Value;
							valuesAdded = true;
						}
						else if (reader.Name == "DestinationDirectory") {
							reader.MoveToContent();
							reader.Read();
							job.DestinationDirectory = reader.Value;
							valuesAdded = true;
						}
						else if (reader.Name == "Name") {
							reader.MoveToContent();
							reader.Read();
							job.Name = reader.Value;
							valuesAdded = true;
						}
					}
				}
				if (valuesAdded) container.Jobs.Add(job); //add the final job that is never added because it has no job behind it
				return container;
			}
			catch {//(Exception e){
				//System.Windows.Forms.MessageBox.Show(e.ToString());
				return null; 
			}
			finally { if (reader != null) reader.Close(); }
		}
	}
}
