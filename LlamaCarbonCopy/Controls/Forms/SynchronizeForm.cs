using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LlamaCarbonCopy.Controls.Forms
{
	public class SynchronizeForm : LlamaCarbonCopy.Controls.Forms.BaseForm
	{
		#region Form Vars

		private System.Windows.Forms.Timer timerCheckReporter;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGrid dgHistory;
		private LlamaCarbonCopy.Controls.BaseControls.SMButton btnClose;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;

		private LlamaCarbonCopy.Controls.BaseControls.SMLabel smLabel1;

		#endregion 
		private System.Windows.Forms.Timer timerProcessing;

		#region Vars

		private int ReportCount = 0;
		private LlamaCarbonCopy.Controls.PurchaseControl purchaseControl1;

private int ProcessingCount = 0;

		#endregion

		#region Constructors

		public SynchronizeForm()
		{
			InitializeComponent();
			this.ReportCount = 0;
		}

		#endregion 

		#region Dispose

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
			this.components = new System.ComponentModel.Container();
			this.timerCheckReporter = new System.Windows.Forms.Timer(this.components);
			this.dgHistory = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnClose = new LlamaCarbonCopy.Controls.BaseControls.SMButton();
			this.smLabel1 = new LlamaCarbonCopy.Controls.BaseControls.SMLabel();
			this.timerProcessing = new System.Windows.Forms.Timer(this.components);
			this.purchaseControl1 = new LlamaCarbonCopy.Controls.PurchaseControl();
			((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// timerCheckReporter
			// 
			this.timerCheckReporter.Interval = 1000;
			this.timerCheckReporter.Tick += new System.EventHandler(this.timerCheckReporter_Tick);
			// 
			// dgHistory
			// 
			this.dgHistory.AlternatingBackColor = System.Drawing.Color.LemonChiffon;
			this.dgHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dgHistory.BackgroundColor = System.Drawing.Color.White;
			this.dgHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgHistory.CaptionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(220)), ((System.Byte)(143)));
			this.dgHistory.CaptionForeColor = System.Drawing.Color.Black;
			this.dgHistory.CaptionText = "Synchronization Results";
			this.dgHistory.DataMember = "";
			this.dgHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgHistory.ForeColor = System.Drawing.Color.Black;
			this.dgHistory.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.dgHistory.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgHistory.Location = new System.Drawing.Point(14, 10);
			this.dgHistory.Name = "dgHistory";
			this.dgHistory.ParentRowsBackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.dgHistory.ReadOnly = true;
			this.dgHistory.SelectionBackColor = System.Drawing.Color.Honeydew;
			this.dgHistory.Size = new System.Drawing.Size(768, 420);
			this.dgHistory.TabIndex = 2;
			this.dgHistory.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																																													this.dataGridTableStyle1});
			this.dgHistory.CurrentCellChanged += new System.EventHandler(this.dgHistory_CurrentCellChanged);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(231)), ((System.Byte)(134)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridTableStyle1.DataGrid = this.dgHistory;
			this.dataGridTableStyle1.ForeColor = System.Drawing.Color.Black;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																																																					this.dataGridTextBoxColumn1,
																																																					this.dataGridTextBoxColumn6,
																																																					this.dataGridTextBoxColumn2,
																																																					this.dataGridTextBoxColumn3,
																																																					this.dataGridTextBoxColumn4,
																																																					this.dataGridTextBoxColumn5});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.Color.Black;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(248)), ((System.Byte)(235)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGridTableStyle1.MappingName = "results";
			this.dataGridTableStyle1.RowHeaderWidth = 25;
			this.dataGridTableStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(120)), ((System.Byte)(143)), ((System.Byte)(119)));
			this.dataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Action";
			this.dataGridTextBoxColumn1.MappingName = "Action";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "g";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "Date";
			this.dataGridTextBoxColumn6.MappingName = "OccuredAt";
			this.dataGridTextBoxColumn6.ReadOnly = true;
			this.dataGridTextBoxColumn6.Width = 115;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Source";
			this.dataGridTextBoxColumn2.MappingName = "OriginalPath";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 200;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Destination";
			this.dataGridTextBoxColumn3.MappingName = "CopyPath";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 200;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Result";
			this.dataGridTextBoxColumn4.MappingName = "ActionResult";
			this.dataGridTextBoxColumn4.ReadOnly = true;
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Description";
			this.dataGridTextBoxColumn5.MappingName = "ActionResultDescription";
			this.dataGridTextBoxColumn5.ReadOnly = true;
			this.dataGridTextBoxColumn5.Width = 200;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DataSource = null;
			this.btnClose.DataSourceProperty = null;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClose.LocalProperty = null;
			this.btnClose.Location = new System.Drawing.Point(682, 442);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 26);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "&Close";
			// 
			// smLabel1
			// 
			this.smLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.smLabel1.BackColor = System.Drawing.Color.Transparent;
			this.smLabel1.DataSource = null;
			this.smLabel1.DataSourceProperty = null;
			this.smLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.smLabel1.ForeColor = System.Drawing.Color.Black;
			this.smLabel1.LocalProperty = null;
			this.smLabel1.Location = new System.Drawing.Point(532, 442);
			this.smLabel1.Name = "smLabel1";
			this.smLabel1.Size = new System.Drawing.Size(144, 26);
			this.smLabel1.TabIndex = 3;
			this.smLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// timerProcessing
			// 
			this.timerProcessing.Enabled = true;
			this.timerProcessing.Interval = 500;
			this.timerProcessing.Tick += new System.EventHandler(this.timerProcessing_Tick);
			// 
			// purchaseControl1
			// 
			this.purchaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.purchaseControl1.Location = new System.Drawing.Point(14, 443);
			this.purchaseControl1.Name = "purchaseControl1";
			this.purchaseControl1.Size = new System.Drawing.Size(110, 24);
			this.purchaseControl1.TabIndex = 4;
			// 
			// SynchronizeForm
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(802, 474);
			this.Controls.Add(this.purchaseControl1);
			this.Controls.Add(this.smLabel1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgHistory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SynchronizeForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Synchronization Results";
			this.Load += new System.EventHandler(this.SynchronizeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Load

		private void SynchronizeForm_Load(object sender, System.EventArgs e) { }
		#endregion 

		#region Public Methods

		public void Synchronize()
		{			
			this.timerCheckReporter.Start();
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.FinishedSynch += new EventHandler(this.HandleSynchFinished);
			sbo.aSynchronizeAll();
			this.ShowDialog();
		}

		public void SynchronizeDirectory(string oDirectory, string cDirectory)
		{
			this.timerCheckReporter.Start();
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.FinishedSynch += new EventHandler(this.HandleSynchFinished);
			sbo.aSynchronizeDirectory(oDirectory, cDirectory);
			this.ShowDialog();
		}
		public void SynchronizeDirectory(string oDirectory)
		{
			this.timerCheckReporter.Start();
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.FinishedSynch += new EventHandler(this.HandleSynchFinished);
			sbo.aSynchronizeDirectory(oDirectory);
			this.ShowDialog();
		}

		public void SynchronizeFile(string oFile, string cFile)
		{
			this.timerCheckReporter.Start();
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.FinishedSynch += new EventHandler(this.HandleSynchFinished);
			sbo.aSynchronizeFile(oFile, cFile);
			this.ShowDialog();
		}

		public void SynchronizeFile(string oFile)
		{
			this.timerCheckReporter.Start();
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.FinishedSynch += new EventHandler(this.HandleSynchFinished);
			sbo.aSynchronizeFile(oFile);
			this.ShowDialog();
		}

		#endregion 

		#region Private Methods

		private void WriteReport(IReporter reporter)
		{
			ActionReportContainer[] containers = reporter.GetFullReport() ;
			
			if( this.ReportCount < containers.Length )
			{
				this.ReportCount = containers.Length;
			
				System.Data.DataTable table = new System.Data.DataTable("results");
				System.Data.DataColumn dc;
				dc = new System.Data.DataColumn("Action",typeof(string));
				table.Columns.Add( dc );
				dc = new System.Data.DataColumn("OccuredAt", typeof(DateTime));
				table.Columns.Add( dc );
				dc = new System.Data.DataColumn("OriginalPath", typeof(string));
				table.Columns.Add( dc );
				dc = new System.Data.DataColumn("CopyPath", typeof(string));
				table.Columns.Add( dc );
				dc = new System.Data.DataColumn("ActionResult", typeof(string));
				table.Columns.Add( dc );
				dc = new System.Data.DataColumn("ActionResultDescription", typeof(string));
				table.Columns.Add( dc );

				foreach( ActionReportContainer container in containers)
				{
					table.Rows.Add( new object[] {
																				 container.Action.ToString(),
																				 container.OccuredAt.ToString("f"),
																				 container.OriginalPath,
																				 container.CopyPath,
																				 container.ActionResult,
																				 container.ActionResultDescription								 
																			 }
					);
				}
				this.dgHistory.DataSource = table;
			}
		}

		private void HandleSynchFinished(object sender, EventArgs args)
		{
			this.timerProcessing.Stop();
			this.smLabel1.Text = "Finished Synchronizing.";			
		}

		#endregion 

		#region Various Handlers

		private void timerCheckReporter_Tick(object sender, System.EventArgs e)
		{
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			WriteReport( sbo.Reporter );
		}

		private void dgHistory_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.dgHistory.Select(this.dgHistory.CurrentCell.RowNumber);
		}

	private void timerProcessing_Tick(object sender, System.EventArgs e)
		{
			string dots = "";
			for( int i = 0; i < ProcessingCount%4; i++){ dots += "."; }
			ProcessingCount++;
			this.smLabel1.Text = "Processing" + dots;
		}

		#endregion 
	}
}

