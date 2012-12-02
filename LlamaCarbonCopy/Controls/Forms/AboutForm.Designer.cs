namespace LlamaCarbonCopy.Controls.Forms {
	partial class AboutForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.llblWebsite = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMsg
			// 
			this.lblMsg.Size = new System.Drawing.Size(477, 93);
			// 
			// llblWebsite
			// 
			this.llblWebsite.ActiveLinkColor = System.Drawing.Color.White;
			this.llblWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.llblWebsite.LinkColor = System.Drawing.Color.White;
			this.llblWebsite.Location = new System.Drawing.Point(12, 102);
			this.llblWebsite.Name = "llblWebsite";
			this.llblWebsite.Size = new System.Drawing.Size(477, 22);
			this.llblWebsite.TabIndex = 2;
			this.llblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llblWebsite.VisitedLinkColor = System.Drawing.Color.White;
			this.llblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWebsite_LinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 194);
			this.Controls.Add(this.llblWebsite);
			this.Name = "AboutForm";
			this.Text = "AboutForm";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.Controls.SetChildIndex(this.llblWebsite, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblMsg, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel llblWebsite;
	}
}