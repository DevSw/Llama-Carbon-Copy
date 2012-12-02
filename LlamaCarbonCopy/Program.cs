using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace LlamaCarbonCopy {
	static class Program {
		private static Mutex mutex;
		private static string mutexName = "lcc.Mutex";
		[STAThread]
		static void Main() {

			try {
				mutex = Mutex.OpenExisting(mutexName);
				//fail if no exception is thrown
				MessageForm frm = new MessageForm();
				VersionBO bo = (VersionBO)SingletonManager.GetSingleton(typeof(VersionBO));
				frm.Msg = String.Format(
					"There is already a copy of {0} v{1} running.\n\n" +
					"I'll close this one, so you can use the other one.\n"+
					"Please check your task bar and system tray for the active copy.", bo.ProgramName, bo.Version);
				frm.ShowDialog();
				Environment.Exit(0);
			}
			catch {
				mutex = new Mutex(true, mutexName);
				LicenseBO bo = (LicenseBO)SingletonManager.GetSingleton(typeof(LicenseBO));
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				if (bo.IsActive())
					Application.Run(new MainForm());

			}
		}
	}
}