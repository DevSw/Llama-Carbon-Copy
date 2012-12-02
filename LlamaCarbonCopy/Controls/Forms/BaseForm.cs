using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms {
	public partial class BaseForm : Form {
		protected string msg;
		public string Msg {
			set { this.msg = value; }
		}
		public BaseForm() { InitializeComponent(); }
		protected virtual void btnOk_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			this.Close();
		}
		protected void BaseForm_Load(object sender, EventArgs e) { lblMsg.Text = msg; }
	}
}