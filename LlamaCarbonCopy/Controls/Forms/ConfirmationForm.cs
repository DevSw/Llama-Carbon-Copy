using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms
{
	public class ConfirmationForm : LlamaCarbonCopy.Controls.Forms.BaseMessageForm
	{
		#region Form Vars
		//private System.ComponentModel.IContainer components = null;
		#endregion

		#region Vars

		#region Question Property Definitions
		protected string question;
		protected bool questionchanged;
		public string Question 
		{
			get 
			{
				return question;
			}
			set 
			{
				question = value;
				questionchanged = true;
				OnQuestionChanged();
			}
		}
		protected void OnQuestionChanged ()
		{
			EventHandler ev = this.QuestionChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler QuestionChanged;
		#endregion

		#region Header Property Definitions
		protected string header;
		protected bool headerchanged;
		public string Header 
		{
			get 
			{
				return header;
			}
			set 
			{
				header = value;
				headerchanged = true;
				OnHeaderChanged();
			}
		}
		protected void OnHeaderChanged ()
		{
			EventHandler ev = this.HeaderChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler HeaderChanged;
		#endregion

		#endregion

		#region Constructors
		public ConfirmationForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public ConfirmationForm(string Question, string Header)
		{
			InitializeComponent();
			this.question = Question;
			this.header = Header;		
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
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.smPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// smPanel1
			// 
			this.smPanel1.Name = "smPanel1";
			// 
			// OK_smButton
			// 
			this.OK_smButton.Name = "OK_smButton";
			// 
			// Cancel_smButton
			// 
			this.Cancel_smButton.Name = "Cancel_smButton";
			// 
			// smLabel1
			// 
			this.smLabel1.Name = "smLabel1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Name = "pictureBox1";
			// 
			// ConfirmationForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(640, 200);
			this.Name = "ConfirmationForm";
			this.Load += new System.EventHandler(this.ConfirmationForm_Load);
			this.smPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Load

		private void ConfirmationForm_Load(object sender, System.EventArgs e)
		{
			this.Text = this.header;
			this.smLabel1.Text = this.question;
		}

		#endregion		
	}
}

