namespace LlamaCarbonCopy.Controls.Forms {
	partial class LicenseForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
			this.keyText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.llblWebsite = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblMsg2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Location = new System.Drawing.Point(0, 177);
			this.panel1.Controls.SetChildIndex(this.btnOk, 0);
			this.panel1.Controls.SetChildIndex(this.btnCancel, 0);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(172, 10);
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
			// 
			// lblMsg
			// 
			this.lblMsg.Size = new System.Drawing.Size(477, 66);
			this.lblMsg.Text = resources.GetString("lblMsg.Text");
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMsg.Visible = false;
			// 
			// keyText
			// 
			this.keyText.Location = new System.Drawing.Point(171, 89);
			this.keyText.Name = "keyText";
			this.keyText.Size = new System.Drawing.Size(318, 20);
			this.keyText.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "License Key";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// llblWebsite
			// 
			this.llblWebsite.ActiveLinkColor = System.Drawing.Color.White;
			this.llblWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.llblWebsite.LinkColor = System.Drawing.Color.White;
			this.llblWebsite.Location = new System.Drawing.Point(12, 152);
			this.llblWebsite.Name = "llblWebsite";
			this.llblWebsite.Size = new System.Drawing.Size(477, 22);
			this.llblWebsite.TabIndex = 4;
			this.llblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llblWebsite.VisitedLinkColor = System.Drawing.Color.White;
			this.llblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWebsite_LinkClicked);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "You can visit our website at:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(253, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 37);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblMsg2
			// 
			this.lblMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMsg2.ForeColor = System.Drawing.Color.White;
			this.lblMsg2.Location = new System.Drawing.Point(12, 9);
			this.lblMsg2.Name = "lblMsg2";
			this.lblMsg2.Size = new System.Drawing.Size(477, 66);
			this.lblMsg2.TabIndex = 6;
			this.lblMsg2.Text = resources.GetString("lblMsg2.Text");
			// 
			// LicenseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 233);
			this.Controls.Add(this.lblMsg2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.llblWebsite);
			this.Controls.Add(this.keyText);
			this.Controls.Add(this.label1);
			this.Name = "LicenseForm";
			this.Text = "License Entry Form";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.keyText, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblMsg, 0);
			this.Controls.SetChildIndex(this.llblWebsite, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.lblMsg2, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox keyText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel llblWebsite;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblMsg2;
	}
}