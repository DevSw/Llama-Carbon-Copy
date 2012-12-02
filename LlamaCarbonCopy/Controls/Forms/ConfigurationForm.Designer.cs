namespace LlamaCarbonCopy.Controls.Forms {
	partial class ConfigurationForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
			this.btnCancel = new System.Windows.Forms.Button();
			this.cboxAutoStartCopyingFiles = new System.Windows.Forms.CheckBox();
			this.txtTimerLength = new System.Windows.Forms.TextBox();
			this.txtMaximumRetryCount = new System.Windows.Forms.TextBox();
			this.lblMaximumRetryCount = new System.Windows.Forms.Label();
			this.lblTimerLength = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Location = new System.Drawing.Point(0, 169);
			this.panel1.Size = new System.Drawing.Size(597, 56);
			this.panel1.Controls.SetChildIndex(this.btnOk, 0);
			this.panel1.Controls.SetChildIndex(this.btnCancel, 0);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(220, 10);
			// 
			// lblMsg
			// 
			this.lblMsg.Location = new System.Drawing.Point(12, 122);
			this.lblMsg.Size = new System.Drawing.Size(28, 26);
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMsg.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(301, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 37);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cboxAutoStartCopyingFiles
			// 
			this.cboxAutoStartCopyingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxAutoStartCopyingFiles.ForeColor = System.Drawing.Color.White;
			this.cboxAutoStartCopyingFiles.Location = new System.Drawing.Point(72, 14);
			this.cboxAutoStartCopyingFiles.Name = "cboxAutoStartCopyingFiles";
			this.cboxAutoStartCopyingFiles.Size = new System.Drawing.Size(439, 29);
			this.cboxAutoStartCopyingFiles.TabIndex = 2;
			this.cboxAutoStartCopyingFiles.Text = "Automatically Start Copying Files When the Program Opens";
			this.cboxAutoStartCopyingFiles.UseVisualStyleBackColor = true;
			// 
			// txtTimerLength
			// 
			this.txtTimerLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimerLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimerLength.Location = new System.Drawing.Point(72, 57);
			this.txtTimerLength.Name = "txtTimerLength";
			this.txtTimerLength.Size = new System.Drawing.Size(100, 22);
			this.txtTimerLength.TabIndex = 3;
			this.toolTip1.SetToolTip(this.txtTimerLength, resources.GetString("txtTimerLength.ToolTip"));
			// 
			// txtMaximumRetryCount
			// 
			this.txtMaximumRetryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaximumRetryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaximumRetryCount.Location = new System.Drawing.Point(72, 101);
			this.txtMaximumRetryCount.Name = "txtMaximumRetryCount";
			this.txtMaximumRetryCount.Size = new System.Drawing.Size(100, 22);
			this.txtMaximumRetryCount.TabIndex = 4;
			this.toolTip1.SetToolTip(this.txtMaximumRetryCount, resources.GetString("txtMaximumRetryCount.ToolTip"));
			// 
			// lblMaximumRetryCount
			// 
			this.lblMaximumRetryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaximumRetryCount.ForeColor = System.Drawing.Color.White;
			this.lblMaximumRetryCount.Location = new System.Drawing.Point(192, 101);
			this.lblMaximumRetryCount.Name = "lblMaximumRetryCount";
			this.lblMaximumRetryCount.Size = new System.Drawing.Size(333, 22);
			this.lblMaximumRetryCount.TabIndex = 5;
			this.lblMaximumRetryCount.Text = "Maximum Retry Count";
			this.lblMaximumRetryCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.lblMaximumRetryCount, resources.GetString("lblMaximumRetryCount.ToolTip"));
			// 
			// lblTimerLength
			// 
			this.lblTimerLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimerLength.ForeColor = System.Drawing.Color.White;
			this.lblTimerLength.Location = new System.Drawing.Point(192, 57);
			this.lblTimerLength.Name = "lblTimerLength";
			this.lblTimerLength.Size = new System.Drawing.Size(333, 22);
			this.lblTimerLength.TabIndex = 6;
			this.lblTimerLength.Text = "Timer Length (in milliseconds)";
			this.lblTimerLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.lblTimerLength, resources.GetString("lblTimerLength.ToolTip"));
			// 
			// toolTip1
			// 
			this.toolTip1.ForeColor = System.Drawing.Color.Black;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.UseAnimation = false;
			// 
			// ConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(597, 225);
			this.Controls.Add(this.lblTimerLength);
			this.Controls.Add(this.lblMaximumRetryCount);
			this.Controls.Add(this.txtMaximumRetryCount);
			this.Controls.Add(this.cboxAutoStartCopyingFiles);
			this.Controls.Add(this.txtTimerLength);
			this.Name = "ConfigurationForm";
			this.Text = "Configuration";
			this.Load += new System.EventHandler(this.ConfigurationForm_Load);
			this.Controls.SetChildIndex(this.txtTimerLength, 0);
			this.Controls.SetChildIndex(this.cboxAutoStartCopyingFiles, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblMsg, 0);
			this.Controls.SetChildIndex(this.txtMaximumRetryCount, 0);
			this.Controls.SetChildIndex(this.lblMaximumRetryCount, 0);
			this.Controls.SetChildIndex(this.lblTimerLength, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cboxAutoStartCopyingFiles;
		private System.Windows.Forms.TextBox txtTimerLength;
		private System.Windows.Forms.TextBox txtMaximumRetryCount;
		private System.Windows.Forms.Label lblMaximumRetryCount;
		private System.Windows.Forms.Label lblTimerLength;
		protected System.Windows.Forms.ToolTip toolTip1;
	}
}