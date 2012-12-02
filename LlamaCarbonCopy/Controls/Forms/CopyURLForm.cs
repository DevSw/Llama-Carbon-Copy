using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class CopyURLForm : BaseForm {
		private string website;
		public string Website { set { website = value; } }
		public CopyURLForm() { InitializeComponent(); }
		private void button1_Click(object sender, EventArgs e) {
			Clipboard.SetDataObject(website, true);
		}
	}
}