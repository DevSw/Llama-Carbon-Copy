namespace LlamaCarbonCopy.Controls.Forms {
	partial class QuestionForm {
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
			this.btnNo = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnNo);
			this.panel1.Controls.SetChildIndex(this.btnOk, 0);
			this.panel1.Controls.SetChildIndex(this.btnNo, 0);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(172, 10);
			this.btnOk.Text = "&Yes";
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNo.ForeColor = System.Drawing.Color.White;
			this.btnNo.Location = new System.Drawing.Point(253, 10);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 37);
			this.btnNo.TabIndex = 1;
			this.btnNo.Text = "&No";
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// QuestionForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnNo;
			this.ClientSize = new System.Drawing.Size(501, 194);
			this.Name = "QuestionForm";
			this.Text = "Confirmation";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Button btnNo;
	}
}