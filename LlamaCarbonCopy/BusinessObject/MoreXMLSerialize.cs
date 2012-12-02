using System.IO;
using System.Xml.Serialization;

namespace LlamaCarbonCopy.BusinessObject{
	public static class MoreXmlSerializer {
		public static T Deserialize<T>(string filename) {
			using (FileStream fileStream = new FileStream(filename, FileMode.Open)) {
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
				return (T)xmlSerializer.Deserialize(fileStream);
			}
		}

		public static void Serialize<T>(T obj, string filename) {
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			//if (File.Exists(filename)) File.Delete(filename);
			using (TextWriter writer = new StreamWriter(filename)) {
				serializer.Serialize(writer, obj);
			}
		}

		public static T Clone<T>(T obj) {
			// this could be done in memory, for now let's do it on file
			string tmp = Path.GetTempFileName();
			Serialize(obj, tmp);
			return Deserialize<T>(tmp);
		}
	}
}