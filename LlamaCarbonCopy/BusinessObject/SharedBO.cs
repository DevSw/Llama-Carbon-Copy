using System;
using System.IO;

namespace LlamaCarbonCopy.BusinessObject
{
	public class SharedBO
	{
		public SharedBO(){}
		private static string directory = "Volz Software\\Llama Carbon Copy\\";
		public static string GetConfigurationFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), directory + "Configuration.xml");
		}
		public static string GetJobsFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), directory + "Jobs.xml");
		}
		public static string GetLogFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), directory + "log.txt");
		}
		public static string GetHelpFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), directory + "help.html");
		}
		public static string GetDataFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), directory + "lcc.dat");
		}

		public static void LaunchWebsite(string website) {
			try {
				//throw new Exception();
				System.Diagnostics.Process.Start(website);
			}
			catch (Exception) {
				LlamaCarbonCopy.Controls.Forms.CopyURLForm frm = new LlamaCarbonCopy.Controls.Forms.CopyURLForm();
				frm.Website = website;					 
				frm.Msg = String.Format(
					"Llama Carbon Copy tried to open the purchase website for you.  " +
					"An error was encountered possibly caused by your security configurations, therefore " +
					"Llama Carbon Copy cannot automatically open the purchase website for you.  \n\n" +
					"Please click the button below to copy the purchase website link, so that you can paste it into " +
					"your web browser.\n" +
					"The purchase webpage is located at: {0}",
					website);
				frm.ShowDialog();
			}
		}
		public static void LaunchHelp() {
			try {
				//throw new Exception();
				System.Diagnostics.Process.Start(SharedBO.GetHelpFile());
			}
			catch (Exception) {
				LlamaCarbonCopy.Controls.Forms.CopyURLForm frm = new LlamaCarbonCopy.Controls.Forms.CopyURLForm();
				frm.Website = SharedBO.GetHelpFile();
				frm.Msg = 
					"Llama Carbon Copy tried to open the Help for you.  " +
					"An error was encountered possibly caused by your security configurations, therefore " +
					"Llama Carbon Copy cannot automatically open the Help information for you.  \n\n" +
					"Please click the button below to copy the help webpage, so that you can paste it into " +
					"your web browser.  The Help file is local to your machine, so you do not need to be connected \n" +
					"to the internet.";
				frm.ShowDialog();
			}
		}

		public static string CalculateDestination(string basePath, string fullPath, string newBasePath) {
			string dir_diff = fullPath.Replace(basePath, "");
			if (dir_diff.StartsWith("\\")) dir_diff = dir_diff.Substring(1);
			return Path.Combine(newBasePath, dir_diff);
		}
	}

	public class UtilsBO {}

	public class ValidateBO 
	{
		public static bool IsInt32(string text)
		{			
			try 
			{
				Convert.ToInt32(text);
				return true;
			}
			catch 
			{
				return false;
			}			
		}	
	}
}
