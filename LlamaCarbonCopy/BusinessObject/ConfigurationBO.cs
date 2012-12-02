using System;
using System.IO;
using System.Text;
using System.Xml;
using LlamaCarbonCopy.Container;
using LlamaCarbonCopy.BusinessObject.Singleton;
namespace LlamaCarbonCopy.BusinessObject 
{ 	
	public class ConfigurationBO : BaseBO 
	{
		public ConfigurationBO() : base() { LoadConfiguration(); }
		private ConfigurationContainer cContainer;
		public ConfigurationContainer CContainer { get { if (cContainer == null) CreateDefaultConfiguration(); return this.cContainer; }}
		public void LoadConfiguration() { 
			try{
				string configFile = SharedBO.GetConfigurationFile();
				//cContainer = MoreXmlSerializer.Deserialize<ConfigurationContainer>(configFile);
				cContainer = ReadConfiguration(configFile);				
			}catch {
				CreateDefaultConfiguration();
			}
		}
		public void Save() {
			try {
				string configFile = SharedBO.GetConfigurationFile();
				//MoreXmlSerializer.Serialize<ConfigurationContainer>(cContainer, configFile);
				WriteConfiguration(cContainer, configFile);
			}
			catch { }
		}
		public void CreateDefaultConfiguration() {
			cContainer = new ConfigurationContainer();
			cContainer.AutoStart = true;
			cContainer.MaxRetryCount = 5;
			cContainer.WaitTime = 3000;
		}

		private ConfigurationContainer ReadConfiguration(string file) {
			ConfigurationContainer container = new ConfigurationContainer();
			XmlTextReader reader = null;
			try {
				reader = new XmlTextReader(new StreamReader(file));
				while (!reader.EOF) {
					reader.Read();
					if (reader.IsStartElement()) {
						if (reader.Name == "WaitTime") {
							reader.MoveToContent();
							reader.Read();
							container.WaitTime = int.Parse(reader.Value);
						}
						else if (reader.Name == "AutoStart") {
							reader.MoveToContent();
							reader.Read();
							container.AutoStart = bool.Parse(reader.Value);
						}
						else if (reader.Name == "MaxRetryCount") {
							reader.MoveToContent();
							reader.Read();
							container.MaxRetryCount = int.Parse(reader.Value);
						}
					}
				}
				return container;
			}
			catch { return null; }
			finally { if (reader != null) reader.Close(); }
		}
		private void WriteConfiguration(ConfigurationContainer container, string file) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
			sb.AppendLine("<ConfigurationContainer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
			sb.AppendFormat("<WaitTime>{0}</WaitTime>\n", container.WaitTime);
			sb.AppendFormat("<AutoStart>{0}</AutoStart>\n", container.AutoStart);
			sb.AppendFormat("<MaxRetryCount>{0}</MaxRetryCount>\n", container.MaxRetryCount);
			sb.AppendLine("</ConfigurationContainer>");

			System.IO.StreamWriter sw = null;
			try {
				sw = new System.IO.StreamWriter(file);
				sw.Write(sb.ToString());
			}
			catch { }
			finally { if (sw != null) sw.Close(); }
		}
	}
}

