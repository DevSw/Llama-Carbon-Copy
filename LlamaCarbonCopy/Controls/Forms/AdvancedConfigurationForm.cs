using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms
{
	public class AdvancedConfigurationForm : LlamaCarbonCopy.Controls.Forms.BaseForm
	{
		#region Form Vars

		private DevComponents.DotNetBar.PanelEx panelEx1;
		private LlamaCarbonCopy.Controls.BaseControls.SMButton btnOk;
		private LlamaCarbonCopy.Controls.BaseControls.SMButton btnCancel;
		private LlamaCarbonCopy.Controls.BaseControls.SMTextBox txtTimerLength;
		private LlamaCarbonCopy.Controls.BaseControls.SMTextBox txtMaximumRetryCount;
		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel1;
		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel2;
		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel3;
		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel4;
		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel5;
		private LlamaCarbonCopy.Controls.BaseControls.SMCheckBox cboxAutoStart;
		private System.ComponentModel.IContainer components = null;
		#endregion 

		#region Vars

		public ConfigurationBO BO 
		{
			get { return (ConfigurationBO)this.bo;}
			set { this.bo = value; }
		}

		#endregion
		
		#region Constructors

		public AdvancedConfigurationForm() : base()
		{
			InitializeComponent();
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
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.smLabel5 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.smLabel4 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.smLabel3 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.smLabel2 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.smLabel1 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.txtMaximumRetryCount = new LlamaCarbonCopy.Controls.BaseControls.SMTextBox();
			this.txtTimerLength = new LlamaCarbonCopy.Controls.BaseControls.SMTextBox();
			this.cboxAutoStart = new LlamaCarbonCopy.Controls.BaseControls.SMCheckBox();
			this.btnCancel = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.btnOk = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.panelEx1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Controls.Add(this.smLabel5);
			this.panelEx1.Controls.Add(this.smLabel4);
			this.panelEx1.Controls.Add(this.smLabel3);
			this.panelEx1.Controls.Add(this.smLabel2);
			this.panelEx1.Controls.Add(this.smLabel1);
			this.panelEx1.Controls.Add(this.txtMaximumRetryCount);
			this.panelEx1.Controls.Add(this.txtTimerLength);
			this.panelEx1.Controls.Add(this.cboxAutoStart);
			this.panelEx1.Controls.Add(this.btnCancel);
			this.panelEx1.Controls.Add(this.btnOk);
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Location = new System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(692, 588);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(142)), ((System.Byte)(179)), ((System.Byte)(231)));
			this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 0;
			// 
			// smLabel5
			// 
			this.smLabel5.BackColor = System.Drawing.Color.Transparent;
			this.smLabel5.DataSource = null;
			this.smLabel5.DataSourceProperty = null;
			this.smLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel5.ForeColor = System.Drawing.Color.Black;
			this.smLabel5.LocalProperty = null;
			this.smLabel5.Location = new System.Drawing.Point(482, 404);
			this.smLabel5.Name = "smLabel5";
			this.smLabel5.Size = new System.Drawing.Size(180, 16);
			this.smLabel5.TabIndex = 13;
			this.smLabel5.Text = "Maximum Retry Count";
			this.smLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// smLabel4
			// 
			this.smLabel4.BackColor = System.Drawing.Color.Transparent;
			this.smLabel4.DataSource = null;
			this.smLabel4.DataSourceProperty = null;
			this.smLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel4.ForeColor = System.Drawing.Color.Black;
			this.smLabel4.LocalProperty = null;
			this.smLabel4.Location = new System.Drawing.Point(482, 172);
			this.smLabel4.Name = "smLabel4";
			this.smLabel4.Size = new System.Drawing.Size(192, 16);
			this.smLabel4.TabIndex = 12;
			this.smLabel4.Text = "Timer Length (in milliseconds)";
			this.smLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// smLabel3
			// 
			this.smLabel3.BackColor = System.Drawing.Color.Transparent;
			this.smLabel3.DataSource = null;
			this.smLabel3.DataSourceProperty = null;
			this.smLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel3.ForeColor = System.Drawing.Color.Black;
			this.smLabel3.LocalProperty = null;
			this.smLabel3.Location = new System.Drawing.Point(24, 400);
			this.smLabel3.Name = "smLabel3";
			this.smLabel3.Size = new System.Drawing.Size(212, 140);
			this.smLabel3.TabIndex = 11;
			this.smLabel3.Text = "Each time a file changes an attempt to copy that file is made (after waiting the " +
				"appropriate time as marked above).  If that copy fails for some reason, attempts" +
				" will be made repeatedly until the file is either copied or the limit entered he" +
				"re is reached.";
			this.smLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// smLabel2
			// 
			this.smLabel2.BackColor = System.Drawing.Color.Transparent;
			this.smLabel2.DataSource = null;
			this.smLabel2.DataSourceProperty = null;
			this.smLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel2.ForeColor = System.Drawing.Color.Black;
			this.smLabel2.LocalProperty = null;
			this.smLabel2.Location = new System.Drawing.Point(24, 170);
			this.smLabel2.Name = "smLabel2";
			this.smLabel2.Size = new System.Drawing.Size(212, 218);
			this.smLabel2.TabIndex = 10;
			this.smLabel2.Text = @"As your computer changes files it goes through several steps.  Each of those steps can trigger the copying mechanism.  For efficiency purposes, it is better to wait some time before attempting to copy a file, just in case it is about to be changed again.  If you are mostly changing small files, testing has shown 3 seconds to be the best.  Alternatively, If you are changing large files a longer wait period is highly recommended.";
			this.smLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// smLabel1
			// 
			this.smLabel1.BackColor = System.Drawing.Color.Transparent;
			this.smLabel1.DataSource = null;
			this.smLabel1.DataSourceProperty = null;
			this.smLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel1.ForeColor = System.Drawing.Color.Black;
			this.smLabel1.LocalProperty = null;
			this.smLabel1.Location = new System.Drawing.Point(24, 28);
			this.smLabel1.Name = "smLabel1";
			this.smLabel1.Size = new System.Drawing.Size(212, 144);
			this.smLabel1.TabIndex = 9;
			this.smLabel1.Text = "If you check this feature then the program will start watching the directories th" +
				"at you already have entered in the program immediately following the program sta" +
				"rting.  If it is unchecked, then the program waits for you to start it manually." +
				"";
			this.smLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMaximumRetryCount
			// 
			this.txtMaximumRetryCount.BackColor = System.Drawing.Color.White;
			this.txtMaximumRetryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaximumRetryCount.DataSource = null;
			this.txtMaximumRetryCount.DataSourceProperty = null;
			this.txtMaximumRetryCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMaximumRetryCount.ForeColor = System.Drawing.Color.Black;
			this.txtMaximumRetryCount.LocalProperty = null;
			this.txtMaximumRetryCount.Location = new System.Drawing.Point(252, 400);
			this.txtMaximumRetryCount.Name = "txtMaximumRetryCount";
			this.txtMaximumRetryCount.Size = new System.Drawing.Size(224, 23);
			this.txtMaximumRetryCount.TabIndex = 8;
			this.txtMaximumRetryCount.Text = "";
			// 
			// txtTimerLength
			// 
			this.txtTimerLength.BackColor = System.Drawing.Color.White;
			this.txtTimerLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimerLength.DataSource = null;
			this.txtTimerLength.DataSourceProperty = null;
			this.txtTimerLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTimerLength.ForeColor = System.Drawing.Color.Black;
			this.txtTimerLength.LocalProperty = null;
			this.txtTimerLength.Location = new System.Drawing.Point(252, 170);
			this.txtTimerLength.Name = "txtTimerLength";
			this.txtTimerLength.Size = new System.Drawing.Size(224, 23);
			this.txtTimerLength.TabIndex = 7;
			this.txtTimerLength.Text = "";
			// 
			// cboxAutoStart
			// 
			this.cboxAutoStart.BackColor = System.Drawing.Color.Transparent;
			this.cboxAutoStart.DataSource = null;
			this.cboxAutoStart.DataSourceProperty = null;
			this.cboxAutoStart.ForeColor = System.Drawing.Color.Black;
			this.cboxAutoStart.LocalProperty = null;
			this.cboxAutoStart.Location = new System.Drawing.Point(252, 28);
			this.cboxAutoStart.Name = "cboxAutoStart";
			this.cboxAutoStart.Size = new System.Drawing.Size(224, 24);
			this.cboxAutoStart.TabIndex = 6;
			this.cboxAutoStart.Text = "Automatically Start Copying Files";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.White;
			this.btnCancel.DataSource = null;
			this.btnCancel.DataSourceProperty = null;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.LocalProperty = null;
			this.btnCancel.Location = new System.Drawing.Point(588, 556);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 26);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.White;
			this.btnOk.DataSource = null;
			this.btnOk.DataSourceProperty = null;
			this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.Black;
			this.btnOk.LocalProperty = null;
			this.btnOk.Location = new System.Drawing.Point(4, 556);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(100, 26);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "&Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// AdvancedConfigurationForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(692, 588);
			this.Controls.Add(this.panelEx1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AdvancedConfigurationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Advanced Configuration";
			this.Load += new System.EventHandler(this.AdvancedConfigurationForm_Load);
			this.panelEx1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Load

		private void AdvancedConfigurationForm_Load(object sender, System.EventArgs e)
		{
			
		}

		#endregion 

		#region IStateChangedListener Members

		public override  void StateChanged(BaseBO sender, StateChangedEventArgs args)
		{
			
		}

		#endregion

		#region Bind Control Data

		/// <summary>
		/// This method must be overridden to make sure that all the
		/// controls know what to bind themselves to.  It only needs to be
		/// called one time, and then the individual controls will know what 
		/// they are bound to.
		/// </summary>
		protected override void BindControlData()
		{
			this.cboxAutoStart.BindData("Checked", this.bo.CONTAINER, "AUTOSTART");
			this.txtTimerLength.BindData("Text", this.bo.CONTAINER, "QTIMERLENGTH");
			this.txtMaximumRetryCount.BindData("Text", this.bo.CONTAINER, "MAXIMUMRETRYCOUNT");
		}

		#endregion

		#region InitializeBO

		protected override void IntializeBO()
		{
			this.BO = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			this.BO.LoadConfiguration(1);
		}

		#endregion
		
		#region Click Handlers

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			if( ValidateConfiguration() ) 
			{
				this.BO.Save( (ConfigurationContainer)this.BO.CONTAINER );
				this.DialogResult = DialogResult.OK;
				this.Close();
			} 
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		#endregion 
		
		#region Private Methods

		private bool ValidateConfiguration()
		{
			string msg = "";
			if (!ValidateBO.IsInt32( this.txtMaximumRetryCount.Text ) )
			{
				msg += OBBO.dom();
			} 
			if (!ValidateBO.IsInt32( this.txtTimerLength.Text ))
			{
				msg += OBBO.mok();
			}
			if( msg.Length > 0 ) 
			{
				System.Windows.Forms.Form iForm = new InfoMessageForm(msg, OBBO.er());
				iForm.ShowDialog();
				return false;
			}
			return true;
		}
		#endregion 
	}
}

