using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class ConfigurationForm : BaseForm {
		public ConfigurationForm() { InitializeComponent(); }
		private void ConfigurationForm_Load(object sender, EventArgs e) {
			string checkboxmsg = "If you check this feature then the program will start watching \n" +
				"the directories that you already have entered in the program immediately \n" +
				"following the program starting.  If it is unchecked, then the program waits for \n" +
				"you to start it manually.";
			toolTip1.SetToolTip(cboxAutoStartCopyingFiles, checkboxmsg);
			string timermsg = "As your computer changes files it goes through several steps.  \n"+
				"Each of those steps can trigger the copying mechanism.  For efficiency purposes,\n" +
				"it is better to wait some time before attempting to copy a file, just in case it \n" +
				"is about to be changed again.  If you are mostly changing small files, testing \n" + 
				"has shown 3 seconds to be the best.  Alternatively, If you are changing large \n"+
				"files a longer wait period is highly recommended.";
			toolTip1.SetToolTip(txtTimerLength, timermsg);
			toolTip1.SetToolTip(lblTimerLength, timermsg);
			string retrycntmsg = "Each time a file changes an attempt to copy that file is \n" +
			"made (after waiting the appropriate time as marked above).  If that copy fails \n" +
			"for some reason, attempts will be made repeatedly until the file is either \n" + 
			"copied or the limit entered here is reached.";
			toolTip1.SetToolTip(txtMaximumRetryCount, retrycntmsg);
			toolTip1.SetToolTip(lblMaximumRetryCount, retrycntmsg);

			ConfigurationBO bo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			cboxAutoStartCopyingFiles.Checked = bo.CContainer.AutoStart;
			txtMaximumRetryCount.Text = bo.CContainer.MaxRetryCount.ToString();
			txtTimerLength.Text = bo.CContainer.WaitTime.ToString();
		}

		private void Save() {
			ConfigurationBO bo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			ConfigurationContainer container = bo.CContainer;
			container.AutoStart = cboxAutoStartCopyingFiles.Checked;
			container.MaxRetryCount = Int32.Parse(txtMaximumRetryCount.Text);
			container.WaitTime = Int32.Parse(txtTimerLength.Text);
			bo.Save();
		}
		private void Warn() {
			MessageForm frm = new MessageForm();
			Msg = "There was an error reading your configurations.  Please make sure that the maximum retry count and the time limit are both whole numbers.";
			frm.ShowDialog();
		}
		private bool Verify() {
			return ValidateBO.IsInt32(txtMaximumRetryCount.Text) && ValidateBO.IsInt32(txtTimerLength.Text);
		}
		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
		protected override void btnOk_Click(object sender, EventArgs e) {
			//save the changes first.
			if (Verify()) Save();
			else Warn();	
			base.btnOk_Click(sender, e);
		}
	}
}