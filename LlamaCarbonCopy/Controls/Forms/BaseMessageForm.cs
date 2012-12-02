using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms
{
	/// <summary>
	/// Summary description for BaseMessageForm.
	/// </summary>
	public class BaseMessageForm : LlamaCarbonCopy.Controls.Forms.BaseForm
	{
		#region Form Variables
		protected LlamaCarbonCopy.Controls.BaseControls.SMPanel smPanel1;
		protected LlamaCarbonCopy.Controls.BaseControls.SMButton OK_smButton;
		protected LlamaCarbonCopy.Controls.BaseControls.SMButton Cancel_smButton;
		protected System.Windows.Forms.PictureBox pictureBox1;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private System.Windows.Forms.RichTextBox rtxtMessage;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		protected System.ComponentModel.Container components = null;

		#endregion

		#region Constructors
		public BaseMessageForm() : base ()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Constructor for use when setting the strings displayed in the 
		/// header and label text themselves.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="header"></param>
		public BaseMessageForm(string message, string header) : this()
		{
			this.Text = header;
			this.rtxtMessage.Text = message;	
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
		protected void InitializeComponent()
		{
			this.smPanel1 = new LlamaCarbonCopy.Controls.BaseControls.SMPanel();
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.rtxtMessage = new System.Windows.Forms.RichTextBox();
			this.OK_smButton = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.Cancel_smButton = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.smPanel1.SuspendLayout();
			this.panelEx1.SuspendLayout();
			this.SuspendLayout();
			// 
			// smPanel1
			// 
			this.smPanel1.BackColor = System.Drawing.Color.Transparent;
			this.smPanel1.Controls.Add(this.panelEx1);
			this.smPanel1.DataSource = null;
			this.smPanel1.DataSourceProperty = null;
			this.smPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.smPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smPanel1.LocalProperty = null;
			this.smPanel1.Location = new System.Drawing.Point(0, 0);
			this.smPanel1.Name = "smPanel1";
			this.smPanel1.Size = new System.Drawing.Size(392, 200);
			this.smPanel1.TabIndex = 0;
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Controls.Add(this.rtxtMessage);
			this.panelEx1.Controls.Add(this.OK_smButton);
			this.panelEx1.Controls.Add(this.Cancel_smButton);
			this.panelEx1.Controls.Add(this.pictureBox1);
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Location = new System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(392, 200);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(142)), ((System.Byte)(179)), ((System.Byte)(231)));
			this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 4;
			// 
			// rtxtMessage
			// 
			this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtxtMessage.Location = new System.Drawing.Point(126, 10);
			this.rtxtMessage.Name = "rtxtMessage";
			this.rtxtMessage.ReadOnly = true;
			this.rtxtMessage.Size = new System.Drawing.Size(256, 142);
			this.rtxtMessage.TabIndex = 4;
			this.rtxtMessage.Text = "";
			// 
			// OK_smButton
			// 
			this.OK_smButton.BackColor = System.Drawing.Color.White;
			this.OK_smButton.DataSource = null;
			this.OK_smButton.DataSourceProperty = null;
			this.OK_smButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.OK_smButton.LocalProperty = null;
			this.OK_smButton.Location = new System.Drawing.Point(12, 164);
			this.OK_smButton.Name = "OK_smButton";
			this.OK_smButton.Size = new System.Drawing.Size(102, 27);
			this.OK_smButton.TabIndex = 0;
			this.OK_smButton.Text = "Ok";
			this.OK_smButton.Click += new System.EventHandler(this.OK_smButton_Click);
			// 
			// Cancel_smButton
			// 
			this.Cancel_smButton.BackColor = System.Drawing.Color.White;
			this.Cancel_smButton.DataSource = null;
			this.Cancel_smButton.DataSourceProperty = null;
			this.Cancel_smButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Cancel_smButton.LocalProperty = null;
			this.Cancel_smButton.Location = new System.Drawing.Point(286, 164);
			this.Cancel_smButton.Name = "Cancel_smButton";
			this.Cancel_smButton.Size = new System.Drawing.Size(94, 27);
			this.Cancel_smButton.TabIndex = 1;
			this.Cancel_smButton.Text = "Cancel";
			this.Cancel_smButton.Click += new System.EventHandler(this.Cancel_smButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// BaseMessageForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(392, 200);
			this.Controls.Add(this.smPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BaseMessageForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.smPanel1.ResumeLayout(false);
			this.panelEx1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Button Handlers

		protected void OK_smButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		protected void Cancel_smButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		#endregion

		#region Form Load

		/// <summary>
		/// Call the base.BaseForm_Load to make sure everything is intact.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public override void BaseForm_Load(object sender, EventArgs args)
		{
			base.BaseForm_Load (sender, args);
			this.Closing += new System.ComponentModel.CancelEventHandler( this.Form_Closing );
		}


		#endregion

		#region Form Closed

		/// <summary>
		/// Make sure the dialog Result is Cancel when they close the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		protected void Form_Closing(object sender, CancelEventArgs args)
		{
			if( this.DialogResult != DialogResult.OK)
				this.DialogResult = DialogResult.Cancel;
		}

		#endregion
	}
}
