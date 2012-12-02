using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Infralution.Licensing;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class LicenseForm : BaseForm {

		private EncryptedLicense _license;
		public EncryptedLicense InstalledLicense {
			get { return _license; }
		}
		private EncryptedLicenseProvider _licenseProvider;
		public EncryptedLicenseProvider LicenseProvider {
			get {
				if (_licenseProvider == null)
					_licenseProvider = this.GetLicenseProvider();
				return _licenseProvider;
			}
			set { _licenseProvider = value; }
		}
		private System.Type _licenseType;
		public Type TypeToLicense {
			get { return _licenseType; }
			set { _licenseType = value; }
		}
		private string _licenseFile;
		public string LicenseFile {
			get { return _licenseFile; }
			set { _licenseFile = value; }
		}

		public bool AllowMultilineKeys {
			get { return keyText.Multiline; }
			set { keyText.Multiline = value; }
		}

		public LicenseForm() { InitializeComponent(); }

		private void llblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			LlamaCarbonCopy.BusinessObject.SharedBO.LaunchWebsite(Properties.Settings.Default.Website);
		}

		public EncryptedLicense ShowDialog(string productName, string companyWebsite, string licenseFile) {
			if (licenseFile == null) throw new ArgumentNullException("licenseFile");

			this.Text = string.Format(Text, productName);
			lblMsg2.Text = string.Format(lblMsg.Text, productName);
			llblWebsite.Text = Properties.Settings.Default.Website;
			lblMsg2.Visible = true;
			//linkLabel.Text = companyWebsite;
			_licenseFile = licenseFile;
			this.ShowDialog();
			return _license;
		}

		protected virtual EncryptedLicenseProvider GetLicenseProvider() {
			return new EncryptedLicenseProvider();
		}

		private string invalidKeyMsg = "The key entered was not a valid license key for this product.  " + 
			"Please double check your entry and try again.";
		private string errorMsg = "An error occured while installing the license.  Ensure you have sufficient " + 
			"priviledges to install the license and please try again.  If you have further trouble follow the link " + 
			"on our license screen to our website and select \"contact\".";
		protected virtual bool InstallLicenseKey(string key) {
			try {
				if (_licenseType == null)
					_license = LicenseProvider.InstallLicense(_licenseFile, key);
				else
					_license = LicenseProvider.InstallLicense(_licenseType, key);
				if (_license == null) {
					//MessageBox.Show(invalidKeyMsg.Text, invalidKeyTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageForm frm = new LlamaCarbonCopy.Controls.Forms.MessageForm();
					frm.Msg = invalidKeyMsg;
					frm.ShowDialog();
				}
				return (_license != null);
			}
			catch {
				//MessageBox.Show(errorMsg.Text, errorTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageForm frm = new LlamaCarbonCopy.Controls.Forms.MessageForm();
				frm.Msg = errorMsg;
				frm.ShowDialog();
			}
			return false;
		}

		private void btnOk_Click_1(object sender, EventArgs e) {
			if (keyText.Text == null || keyText.Text.Trim().Length == 0) {				
				this.Close();
			}
			else {
				if (InstallLicenseKey(keyText.Text)) {					
					this.Close();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			_license = null;
			this.Close();
		}
	}
}