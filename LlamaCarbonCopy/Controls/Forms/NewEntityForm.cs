using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LlamaCarbonCopy.Container;
using LlamaCarbonCopy.Controls.Transport;

namespace LlamaCarbonCopy.Controls.Forms
{
	public class NewEntityForm : LlamaCarbonCopy.Controls.Forms.BaseForm
	{
		#region Form Variables

		protected LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel1;
		protected LlamaCarbonCopy.Controls.BaseControls.SMTextBox smTextBox1;
		protected LlamaCarbonCopy.Controls.BaseControls.SMButton OK_smButton;
		protected LlamaCarbonCopy.Controls.BaseControls.SMButton Cancel_smButton;
		private System.ComponentModel.IContainer components = null;

		#endregion
		private DevComponents.DotNetBar.PanelEx panelEx1;

		#region Variables

		#region TRANSPORT Property definitions

		private BaseContainerTransport transport;
		

		public BaseContainerTransport TRANSPORT 
		{
			get{ return transport;}
			set
			{ 
				transport = value;
				OnTRANSPORTChanged();
			}
		}

		protected void OnTRANSPORTChanged()
		{
			EventHandler ev = this.TRANSPORTChanged;
			if( ev != null)
				ev(this, EventArgs.Empty);
		}

		public event EventHandler TRANSPORTChanged;
		#endregion

		#endregion

		#region Constructor

		public NewEntityForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public NewEntityForm(BaseContainerTransport transport) : this()
		{
			this.transport = transport;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NewEntityForm));
			this.OK_smButton = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.Cancel_smButton = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.smLabel1 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.smTextBox1 = new LlamaCarbonCopy.Controls.BaseControls.SMTextBox();
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OK_smButton
			// 
			this.OK_smButton.BackColor = System.Drawing.Color.White;
			this.OK_smButton.DataSource = null;
			this.OK_smButton.DataSourceProperty = null;
			this.OK_smButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.OK_smButton.LocalProperty = null;
			this.OK_smButton.Location = new System.Drawing.Point(28, 82);
			this.OK_smButton.Name = "OK_smButton";
			this.OK_smButton.Size = new System.Drawing.Size(106, 26);
			this.OK_smButton.TabIndex = 1;
			this.OK_smButton.Text = "&Ok";
			this.OK_smButton.Click += new System.EventHandler(this.OK_smButton_Click);
			// 
			// Cancel_smButton
			// 
			this.Cancel_smButton.BackColor = System.Drawing.Color.White;
			this.Cancel_smButton.DataSource = null;
			this.Cancel_smButton.DataSourceProperty = null;
			this.Cancel_smButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_smButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Cancel_smButton.LocalProperty = null;
			this.Cancel_smButton.Location = new System.Drawing.Point(140, 82);
			this.Cancel_smButton.Name = "Cancel_smButton";
			this.Cancel_smButton.Size = new System.Drawing.Size(104, 26);
			this.Cancel_smButton.TabIndex = 2;
			this.Cancel_smButton.Text = "&Cancel";
			this.Cancel_smButton.Click += new System.EventHandler(this.Cancel_smButton_Click);
			// 
			// smLabel1
			// 
			this.smLabel1.BackColor = System.Drawing.Color.Transparent;
			this.smLabel1.DataSource = null;
			this.smLabel1.DataSourceProperty = null;
			this.smLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel1.ForeColor = System.Drawing.Color.Black;
			this.smLabel1.LocalProperty = null;
			this.smLabel1.Location = new System.Drawing.Point(28, 8);
			this.smLabel1.Name = "smLabel1";
			this.smLabel1.Size = new System.Drawing.Size(200, 20);
			this.smLabel1.TabIndex = 2;
			this.smLabel1.Text = "Enter a name for the new item.";
			this.smLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// smTextBox1
			// 
			this.smTextBox1.BackColor = System.Drawing.Color.White;
			this.smTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.smTextBox1.DataSource = null;
			this.smTextBox1.DataSourceProperty = null;
			this.smTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smTextBox1.ForeColor = System.Drawing.Color.Black;
			this.smTextBox1.LocalProperty = null;
			this.smTextBox1.Location = new System.Drawing.Point(28, 40);
			this.smTextBox1.Name = "smTextBox1";
			this.smTextBox1.Size = new System.Drawing.Size(216, 23);
			this.smTextBox1.TabIndex = 0;
			this.smTextBox1.Text = "";
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Controls.Add(this.OK_smButton);
			this.panelEx1.Controls.Add(this.Cancel_smButton);
			this.panelEx1.Controls.Add(this.smLabel1);
			this.panelEx1.Controls.Add(this.smTextBox1);
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Location = new System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(282, 126);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(142)), ((System.Byte)(179)), ((System.Byte)(231)));
			this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 3;
			// 
			// NewEntityForm
			// 
			this.AcceptButton = this.OK_smButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.Cancel_smButton;
			this.ClientSize = new System.Drawing.Size(282, 126);
			this.Controls.Add(this.panelEx1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewEntityForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "New";
			this.Load += new System.EventHandler(this.NewEntityForm_Load);
			this.Closed += new System.EventHandler(this.NewEntityForm_Closed);
			this.panelEx1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Form Closed

		private void NewEntityForm_Closed(object sender, System.EventArgs e)
		{
			if( !this.transport.CREATIONSUCCEEDED )
				this.transport.CREATIONSUCCEEDED = false;
		}

		#endregion

		#region Cancel Button Handler
		private void Cancel_smButton_Click(object sender, System.EventArgs e)
		{
			this.transport.CREATIONSUCCEEDED = false;
			this.Close();
		}

		#endregion

		#region OK Button Handler

		private void OK_smButton_Click(object sender, System.EventArgs e)
		{
			this.transport.CREATIONSUCCEEDED = true;
			this.Close();
		}

		#endregion

		#region Form Loaded

		private void NewEntityForm_Load(object sender, System.EventArgs e)
		{
			if( this.transport != null &&
				this.transport.CONTAINER != null)
			{
				this.smTextBox1.BindData("TEXT", this.transport.CONTAINER, "NAME");
			}
		}

		#endregion
	}

	
}

