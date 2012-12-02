//using LlamaCarbonCopy.BusinessObject.Registry;
using LlamaCarbonCopy.Container;
using LlamaCarbonCopy.Controls.Forms;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Infralution.Licensing;

namespace LlamaCarbonCopy.BusinessObject {

	public class LicenseBO {
		static string ValidationParameters = @"<LicenseParameters><RSAKeyValue><Modulus>xsA2kiHhkFEswQomiUSP2wkYVIBOuwgyxnFatR3JIn+8LNYljkra54FM+5UxAUg4oinlPDwBoRzI17nx/8yFueo+KNj1W3tAz0FDjS9Ki9iMtdHOhQDupSdaQNOLNepyLMex679U3hJCWSKPwuQMY8OGMVzKDLVTQd5lDYmRX0c=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue><DesignSignature>PilyKqgDdlwdyU8ppm9mHD66YdEGjKEQzJ5yfYPHg2V4Cn5dyeEewDTxKDnBXXpx820ZQiyIQn4tKBNoZLGxIErZqw9RGcHmtt7OKN1KdUx5UzyyvvViuq/nhn4v1PJ531dGqHqRtqViA38IKdOAWHigATb4vT5xhWhP0qKDM48=</DesignSignature><RuntimeSignature>AX4+OF3yHOBHUdc3Z+L0vIYCQRvW25sprH8CRUCrT9lBsBox3g7QmcNAjQsdO6guq3vGEKguzSkdKkvxYgFcMIg4LX0a8CIt3I+pNEOjXUK6bI2VQGa115ych/wUMVnzhCmxGiI7TAXrarYS0eKgnbJPcv8IxCWNGZyNPBvecOA=</RuntimeSignature><KeyStrength>7</KeyStrength></LicenseParameters>";

		public LicenseBO() { }		
		public bool IsActive() {
			EncryptedLicenseProvider provider = new EncryptedLicenseProvider();
			EncryptedLicense license = provider.GetLicense(LicenseBO.ValidationParameters, GetLicenseFile());

			if (license == null) {
				EvaluationMonitor monitor = new EvaluationMonitor("SpittingImage");
				if (monitor.DaysInUse > 15 || monitor.Invalid) {
					QuestionForm frm = new QuestionForm();
					frm.Msg = "Your trial license has expired.  Would you like to enter a license key to activate the software?";
					if (frm.ShowDialog() == DialogResult.OK) {
						LicenseForm licfrm = new LicenseForm();
						license = licfrm.ShowDialog("Llama Carbon Copy", Properties.Settings.Default.Website, LicenseBO.GetLicenseFile());
						if (license != null) OnLicensed(EventArgs.Empty);
					}
				}
				else {
					MessageForm frm = new MessageForm();
					frm.Msg = string.Format("You are on day {0} of your 15 day evaluation.", monitor.DaysInUse);
					frm.ShowDialog();
					return true;
				}
			}
			if (license == null)
				return false;
			else
				return true;
		}
		public void AttemptLicense() {
			EncryptedLicenseProvider provider = new EncryptedLicenseProvider();			
			EncryptedLicense license = provider.GetLicense(LicenseBO.ValidationParameters, GetLicenseFile());
			if (license != null) {
				MessageForm frm = new MessageForm();
				frm.Msg = "Your license is installed properly.  No further licensing is required.";
				frm.ShowDialog();
				return;
			}
			else {
				LicenseForm licfrm = new LicenseForm();
				license = licfrm.ShowDialog("Llama Carbon Copy", Properties.Settings.Default.Website, LicenseBO.GetLicenseFile());
				if (licfrm.DialogResult == DialogResult.Cancel) return;
				if (license != null) {
					//congratulate
					OnLicensed(EventArgs.Empty);
					MessageForm frm = new MessageForm();
					frm.Msg = "You have successfully installed your license.";
					frm.ShowDialog();
				}
				else {
					//ask if they want to try again
					QuestionForm frm = new QuestionForm();
					frm.Msg = "There was a problem creating your license.  Would you like to try again?";
					if (frm.ShowDialog() == DialogResult.OK) { AttemptLicense(); }
				}
			}
		}
		public bool IsLicensed() {
			EncryptedLicenseProvider provider = new EncryptedLicenseProvider();
			EncryptedLicense license = provider.GetLicense(LicenseBO.ValidationParameters, GetLicenseFile());
			return license != null;
		}
		public static string GetLicenseFile() {
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				@"Volz Software\Llama Carbon Copy\LicensedApp.lic");
		}
		public event EventHandler Licensed;
		private void OnLicensed(EventArgs e) {
			EventHandler ev = Licensed;
			if (ev != null) ev(this, e);
		}
	}
}
