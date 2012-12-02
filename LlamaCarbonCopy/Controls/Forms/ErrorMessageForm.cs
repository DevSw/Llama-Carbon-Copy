using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms
{
	/// <summary>
	/// Summary description for ErrorMessageForm.
	/// </summary>
	public class ErrorMessageForm : LlamaCarbonCopy.Controls.Forms.BaseMessageForm
	{
		#region Form Variables
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private new System.ComponentModel.Container components = null;

		#endregion

		#region Constructors

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ErrorMessageForm() : base()
		{
			InitializeComponent();
		}

		/// <summary>
		/// For use with message and header
		/// </summary>
		/// <param name="message"></param>
		/// <param name="header"></param>
		public ErrorMessageForm(string message, string header) : base (message, header)
		{
			this.InitializeComponent();
		}

		#endregion

		#region Dispose

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private new void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ErrorMessageForm));
			this.SuspendLayout();
			// 
			// smPanel1
			// 
			this.smPanel1.Name = "smPanel1";
			this.smPanel1.Size = new System.Drawing.Size(398, 200);
			// 
			// OK_smButton
			// 
			this.OK_smButton.Name = "OK_smButton";
			// 
			// Cancel_smButton
			// 
			this.Cancel_smButton.Name = "Cancel_smButton";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Name = "pictureBox1";
			// 
			// ErrorMessageForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(398, 200);
			this.Name = "ErrorMessageForm";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
