using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class AboutForm : BaseForm {
		public AboutForm() { 
			InitializeComponent(); 
			VersionBO bo = (VersionBO)SingletonManager.GetSingleton(typeof(VersionBO ));
			this.msg = bo.ProgramName + " v" + bo.Version + "\n" + "By:\n" + "Volz Software";
		}
		private void AboutForm_Load(object sender, EventArgs e) { 
			llblWebsite.Text = Properties.Settings.Default.Website;						
		}
		private void llblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			SharedBO.LaunchWebsite(Properties.Settings.Default.Website);
		}
	}
}