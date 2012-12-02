using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class QuestionForm : BaseForm {
		public QuestionForm() { InitializeComponent(); }
		private void btnNo_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}