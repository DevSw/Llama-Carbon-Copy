using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls {
	public partial class LicenseControl : UserControl {
		public LicenseControl() {
			InitializeComponent();
		}
		private void LicenseControl_Load(object sender, EventArgs e) {
			LicenseBO bo = (LicenseBO)SingletonManager.GetSingleton(typeof(LicenseBO));
			if (bo.IsLicensed()) this.Visible = false;
			else {
				this.Visible = true;
				bo.Licensed += new EventHandler(bo_Licensed);
			}
		}
		private void bo_Licensed(object sender, EventArgs e) {
			this.Visible = false;
		}
		protected void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			VersionBO bo = (VersionBO)SingletonManager.GetSingleton(typeof(VersionBO));
			SharedBO.LaunchWebsite(Properties.Settings.Default.SalesWebsite+"?version="+bo.ToString());
		}
	}
}
