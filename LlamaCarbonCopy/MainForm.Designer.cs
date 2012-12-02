namespace LlamaCarbonCopy {
	partial class MainForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnMMFile = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMCopy = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMStartWatching = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMStopWatching = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMSynchronizeAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMExit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMConfiguration = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMOnlineHelp = new DevComponents.DotNetBar.ButtonItem();
            this.MMVisitOurWebsite = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMLicensing = new DevComponents.DotNetBar.ButtonItem();
            this.btnMMAbout = new DevComponents.DotNetBar.ButtonItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnTBNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnTBEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnTBSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnTBDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnTBSynchronizeAll = new DevComponents.DotNetBar.ButtonItem();
            this.BIToolbarSynchAllJobs = new DevComponents.DotNetBar.ButtonItem();
            this.BIToolbarSynchronizeSelectedJob = new DevComponents.DotNetBar.ButtonItem();
            this.biMatch = new DevComponents.DotNetBar.ButtonItem();
            this.biMatchAllJobs = new DevComponents.DotNetBar.ButtonItem();
            this.biMatchSelectedJob = new DevComponents.DotNetBar.ButtonItem();
            this.btnTBOnlineHelp = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.licenseControl1 = new LlamaCarbonCopy.Controls.LicenseControl();
            this.label2 = new System.Windows.Forms.Label();
            this.gridJobs = new System.Windows.Forms.DataGridView();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WatchSubDirectories = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLoadHistory = new System.Windows.Forms.Button();
            this.lblLoadingFiles = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceLastChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationLastChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fbDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.fbDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.dockSite4;
            this.dotNetBarManager1.DefinitionName = "";
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.LeftDockSite = this.dockSite1;
            this.dotNetBarManager1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.dockSite2;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager1.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 564);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(792, 0);
            this.dockSite4.TabIndex = 3;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 80);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 484);
            this.dockSite1.TabIndex = 0;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(792, 80);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 484);
            this.dockSite2.TabIndex = 1;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 564);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(792, 0);
            this.dockSite8.TabIndex = 7;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 80);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 484);
            this.dockSite5.TabIndex = 4;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(792, 80);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 484);
            this.dockSite6.TabIndex = 5;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.BackColor2 = System.Drawing.Color.White;
            this.dockSite7.BackColorGradientAngle = 180;
            this.dockSite7.Controls.Add(this.bar1);
            this.dockSite7.Controls.Add(this.bar2);
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(792, 80);
            this.dockSite7.TabIndex = 6;
            this.dockSite7.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMMFile,
            this.buttonItem10,
            this.buttonItem12});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(792, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnMMFile
            // 
            this.btnMMFile.Name = "btnMMFile";
            this.btnMMFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMMNew,
            this.btnMMEdit,
            this.btnMMCopy,
            this.btnMMDelete,
            this.btnMMStartWatching,
            this.btnMMStopWatching,
            this.btnMMSynchronizeAll,
            this.btnMMExit});
            this.btnMMFile.Text = "File";
            // 
            // btnMMNew
            // 
            this.btnMMNew.Name = "btnMMNew";
            this.btnMMNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnMMNew.Text = "New";
            this.btnMMNew.Click += new System.EventHandler(this.btnMMNew_Click);
            // 
            // btnMMEdit
            // 
            this.btnMMEdit.Name = "btnMMEdit";
            this.btnMMEdit.Text = "Edit";
            this.btnMMEdit.Click += new System.EventHandler(this.btnMMEdit_Click);
            // 
            // btnMMCopy
            // 
            this.btnMMCopy.Name = "btnMMCopy";
            this.btnMMCopy.Text = "Copy";
            this.btnMMCopy.Click += new System.EventHandler(this.btnMMCopy_Click);
            // 
            // btnMMDelete
            // 
            this.btnMMDelete.Name = "btnMMDelete";
            this.btnMMDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel);
            this.btnMMDelete.Text = "Delete";
            this.btnMMDelete.Click += new System.EventHandler(this.btnMMDelete_Click);
            // 
            // btnMMStartWatching
            // 
            this.btnMMStartWatching.BeginGroup = true;
            this.btnMMStartWatching.Name = "btnMMStartWatching";
            this.btnMMStartWatching.Text = "Start Watching";
            this.btnMMStartWatching.Click += new System.EventHandler(this.btnMMStartWatching_Click);
            // 
            // btnMMStopWatching
            // 
            this.btnMMStopWatching.Name = "btnMMStopWatching";
            this.btnMMStopWatching.Text = "Stop Watching";
            this.btnMMStopWatching.Click += new System.EventHandler(this.btnMMStopWatching_Click);
            // 
            // btnMMSynchronizeAll
            // 
            this.btnMMSynchronizeAll.BeginGroup = true;
            this.btnMMSynchronizeAll.Name = "btnMMSynchronizeAll";
            this.btnMMSynchronizeAll.Text = "Synchronize All Folders";
            this.btnMMSynchronizeAll.Click += new System.EventHandler(this.btnMMSynchronizeAll_Click);
            // 
            // btnMMExit
            // 
            this.btnMMExit.BeginGroup = true;
            this.btnMMExit.Name = "btnMMExit";
            this.btnMMExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btnMMExit.Text = "Exit";
            this.btnMMExit.Click += new System.EventHandler(this.btnMMExit_Click);
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMMConfiguration});
            this.buttonItem10.Text = "Tools";
            // 
            // btnMMConfiguration
            // 
            this.btnMMConfiguration.Name = "btnMMConfiguration";
            this.btnMMConfiguration.Text = "Configuration";
            this.btnMMConfiguration.Click += new System.EventHandler(this.btnMMConfiguration_Click);
            // 
            // buttonItem12
            // 
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMMOnlineHelp,
            this.MMVisitOurWebsite,
            this.btnMMLicensing,
            this.btnMMAbout});
            this.buttonItem12.Text = "Help";
            // 
            // btnMMOnlineHelp
            // 
            this.btnMMOnlineHelp.Name = "btnMMOnlineHelp";
            this.btnMMOnlineHelp.Text = "View Help Manual";
            this.btnMMOnlineHelp.Click += new System.EventHandler(this.btnMMOnlineHelp_Click);
            // 
            // MMVisitOurWebsite
            // 
            this.MMVisitOurWebsite.Name = "MMVisitOurWebsite";
            this.MMVisitOurWebsite.Text = "Visit Our Website";
            this.MMVisitOurWebsite.Click += new System.EventHandler(this.btnMMVisitOurWebsite_Click);
            // 
            // btnMMLicensing
            // 
            this.btnMMLicensing.Name = "btnMMLicensing";
            this.btnMMLicensing.Text = "Licensing";
            this.btnMMLicensing.Click += new System.EventHandler(this.btnMMLicensing_Click);
            // 
            // btnMMAbout
            // 
            this.btnMMAbout.BeginGroup = true;
            this.btnMMAbout.Name = "btnMMAbout";
            this.btnMMAbout.Text = "About Llama Carbon Copy";
            this.btnMMAbout.Click += new System.EventHandler(this.btnMMAbout_Click);
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.bar2.DockLine = 1;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTBNew,
            this.btnTBEdit,
            this.btnTBSave,
            this.btnTBDelete,
            this.btnTBSynchronizeAll,
            this.biMatch,
            this.btnTBOnlineHelp});
            this.bar2.Location = new System.Drawing.Point(0, 25);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(308, 55);
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar2.TabIndex = 1;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnTBNew
            // 
            this.btnTBNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBNew.Image = global::LlamaCarbonCopy.Properties.Resources.NewDoc23x23;
            this.btnTBNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBNew.Name = "btnTBNew";
            this.btnTBNew.Text = "New";
            this.btnTBNew.Tooltip = "Add a New Job";
            this.btnTBNew.Click += new System.EventHandler(this.btnTBNew_Click);
            // 
            // btnTBEdit
            // 
            this.btnTBEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBEdit.Image = global::LlamaCarbonCopy.Properties.Resources.explore23x23;
            this.btnTBEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBEdit.Name = "btnTBEdit";
            this.btnTBEdit.Text = "Edit";
            this.btnTBEdit.Tooltip = "Edit the Selected Job";
            this.btnTBEdit.Click += new System.EventHandler(this.btnTBEdit_Click);
            // 
            // btnTBSave
            // 
            this.btnTBSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBSave.Image = global::LlamaCarbonCopy.Properties.Resources.copy1;
            this.btnTBSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBSave.Name = "btnTBSave";
            this.btnTBSave.Text = "Copy";
            this.btnTBSave.Tooltip = "Copy the Selected Job";
            this.btnTBSave.Click += new System.EventHandler(this.btnTBSave_Click);
            // 
            // btnTBDelete
            // 
            this.btnTBDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBDelete.Image = global::LlamaCarbonCopy.Properties.Resources.SIDeleteV123X23;
            this.btnTBDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBDelete.Name = "btnTBDelete";
            this.btnTBDelete.Text = "Delete";
            this.btnTBDelete.Tooltip = "Delete the Selected Job";
            this.btnTBDelete.Click += new System.EventHandler(this.btnTBDelete_Click);
            // 
            // btnTBSynchronizeAll
            // 
            this.btnTBSynchronizeAll.BeginGroup = true;
            this.btnTBSynchronizeAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBSynchronizeAll.Image = global::LlamaCarbonCopy.Properties.Resources.refresh23x23;
            this.btnTBSynchronizeAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBSynchronizeAll.Name = "btnTBSynchronizeAll";
            this.btnTBSynchronizeAll.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BIToolbarSynchAllJobs,
            this.BIToolbarSynchronizeSelectedJob});
            this.btnTBSynchronizeAll.Text = "Synch";
            this.btnTBSynchronizeAll.Tooltip = "Synchronize All Watched Folders";
            this.btnTBSynchronizeAll.Click += new System.EventHandler(this.btnTBSynchronizeAll_Click);
            // 
            // BIToolbarSynchAllJobs
            // 
            this.BIToolbarSynchAllJobs.Name = "BIToolbarSynchAllJobs";
            this.BIToolbarSynchAllJobs.Text = "Synchronize All Jobs";
            this.BIToolbarSynchAllJobs.Click += new System.EventHandler(this.BIToolbarSynchAllJobs_Click);
            // 
            // BIToolbarSynchronizeSelectedJob
            // 
            this.BIToolbarSynchronizeSelectedJob.Name = "BIToolbarSynchronizeSelectedJob";
            this.BIToolbarSynchronizeSelectedJob.Text = "Synchronize Selected Job";
            this.BIToolbarSynchronizeSelectedJob.Click += new System.EventHandler(this.BIToolbarSynchronizeSelectedJob_Click);
            // 
            // biMatch
            // 
            this.biMatch.BeginGroup = true;
            this.biMatch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biMatch.Image = global::LlamaCarbonCopy.Properties.Resources.match23x23;
            this.biMatch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biMatch.Name = "biMatch";
            this.biMatch.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biMatchAllJobs,
            this.biMatchSelectedJob});
            this.biMatch.Text = "Match";
            this.biMatch.Click += new System.EventHandler(this.biMatch_Click);
            // 
            // biMatchAllJobs
            // 
            this.biMatchAllJobs.Name = "biMatchAllJobs";
            this.biMatchAllJobs.Text = "Match All Jobs";
            this.biMatchAllJobs.Click += new System.EventHandler(this.biMatchAllJobs_Click);
            // 
            // biMatchSelectedJob
            // 
            this.biMatchSelectedJob.Name = "biMatchSelectedJob";
            this.biMatchSelectedJob.Text = "Match Selected Job";
            this.biMatchSelectedJob.Click += new System.EventHandler(this.biMatchSelectedJob_Click);
            // 
            // btnTBOnlineHelp
            // 
            this.btnTBOnlineHelp.BeginGroup = true;
            this.btnTBOnlineHelp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTBOnlineHelp.Image = global::LlamaCarbonCopy.Properties.Resources.help2;
            this.btnTBOnlineHelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTBOnlineHelp.Name = "btnTBOnlineHelp";
            this.btnTBOnlineHelp.Text = "Help";
            this.btnTBOnlineHelp.Tooltip = "Help";
            this.btnTBOnlineHelp.Click += new System.EventHandler(this.btnTBOnlineHelp_Click);
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 80);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(792, 0);
            this.dockSite3.TabIndex = 2;
            this.dockSite3.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Orange;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.splitContainer1.Panel1.Controls.Add(this.licenseControl1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.gridJobs);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadHistory);
            this.splitContainer1.Panel2.Controls.Add(this.lblLoadingFiles);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 484);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 8;
            // 
            // licenseControl1
            // 
            this.licenseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.licenseControl1.Location = new System.Drawing.Point(650, 7);
            this.licenseControl1.Name = "licenseControl1";
            this.licenseControl1.Size = new System.Drawing.Size(139, 29);
            this.licenseControl1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job Descriptions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridJobs
            // 
            this.gridJobs.AllowUserToAddRows = false;
            this.gridJobs.AllowUserToDeleteRows = false;
            this.gridJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridJobs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobName,
            this.Source,
            this.Destination,
            this.WatchSubDirectories});
            this.gridJobs.GridColor = System.Drawing.Color.Orange;
            this.gridJobs.Location = new System.Drawing.Point(3, 39);
            this.gridJobs.MultiSelect = false;
            this.gridJobs.Name = "gridJobs";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridJobs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridJobs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridJobs.Size = new System.Drawing.Size(786, 263);
            this.gridJobs.TabIndex = 1;
            this.gridJobs.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridJobs_CellValidating);
            this.gridJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridJobs_CellClick);
            this.gridJobs.CurrentCellChanged += new System.EventHandler(this.gridJobs_CurrentCellChanged);
            this.gridJobs.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridJobs_CellEnter);
            this.gridJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridJobs_CellContentClick);
            // 
            // JobName
            // 
            this.JobName.HeaderText = "Job Name";
            this.JobName.Name = "JobName";
            // 
            // Source
            // 
            this.Source.FillWeight = 250F;
            this.Source.HeaderText = "Source Directory";
            this.Source.Name = "Source";
            // 
            // Destination
            // 
            this.Destination.FillWeight = 250F;
            this.Destination.HeaderText = "Destination Directory";
            this.Destination.Name = "Destination";
            // 
            // WatchSubDirectories
            // 
            this.WatchSubDirectories.FillWeight = 120F;
            this.WatchSubDirectories.HeaderText = "Include Subdirectories";
            this.WatchSubDirectories.Name = "WatchSubDirectories";
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.Location = new System.Drawing.Point(110, 3);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(110, 30);
            this.btnLoadHistory.TabIndex = 6;
            this.btnLoadHistory.Text = "Load History";
            this.btnLoadHistory.UseVisualStyleBackColor = true;
            this.btnLoadHistory.Click += new System.EventHandler(this.btnLoadHistory_Click);
            // 
            // lblLoadingFiles
            // 
            this.lblLoadingFiles.BackColor = System.Drawing.Color.White;
            this.lblLoadingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingFiles.ForeColor = System.Drawing.Color.Black;
            this.lblLoadingFiles.Location = new System.Drawing.Point(305, 77);
            this.lblLoadingFiles.Name = "lblLoadingFiles";
            this.lblLoadingFiles.Size = new System.Drawing.Size(182, 33);
            this.lblLoadingFiles.TabIndex = 5;
            this.lblLoadingFiles.Text = "Loading Files ...";
            this.lblLoadingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadingFiles.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.SourceLastChanged,
            this.DestinationLastChanged,
            this.Status});
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(786, 103);
            this.dataGridView1.TabIndex = 2;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // SourceLastChanged
            // 
            this.SourceLastChanged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SourceLastChanged.HeaderText = "Source File Changed";
            this.SourceLastChanged.Name = "SourceLastChanged";
            this.SourceLastChanged.ReadOnly = true;
            this.SourceLastChanged.Width = 131;
            // 
            // DestinationLastChanged
            // 
            this.DestinationLastChanged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DestinationLastChanged.HeaderText = "Destination File Changed";
            this.DestinationLastChanged.Name = "DestinationLastChanged";
            this.DestinationLastChanged.ReadOnly = true;
            this.DestinationLastChanged.Width = 150;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.HeaderText = "File Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbProgress);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 27);
            this.panel1.TabIndex = 4;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.ForeColor = System.Drawing.Color.Orange;
            this.pbProgress.Location = new System.Drawing.Point(617, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(168, 23);
            this.pbProgress.TabIndex = 2;
            this.pbProgress.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoEllipsis = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProgress.Location = new System.Drawing.Point(127, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(484, 23);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgress.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "File History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NewDoc32x32.png");
            this.imageList1.Images.SetKeyName(1, "explore23x23.png");
            this.imageList1.Images.SetKeyName(2, "SIsaveas23x23.png");
            this.imageList1.Images.SetKeyName(3, "SIDeleteV123X23.png");
            this.imageList1.Images.SetKeyName(4, "refresh32x30.png");
            // 
            // fbDialogSource
            // 
            this.fbDialogSource.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fbDialogDestination
            // 
            this.fbDialogDestination.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Llama Carbon Copy";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(792, 564);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.dockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite5;
		private DevComponents.DotNetBar.DockSite dockSite6;
		private DevComponents.DotNetBar.DockSite dockSite7;
		private DevComponents.DotNetBar.DockSite dockSite8;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem btnMMFile;
		private DevComponents.DotNetBar.ButtonItem btnMMNew;
		private DevComponents.DotNetBar.ButtonItem btnMMEdit;
		private DevComponents.DotNetBar.ButtonItem btnMMCopy;
		private DevComponents.DotNetBar.ButtonItem btnMMDelete;
		private DevComponents.DotNetBar.ButtonItem btnMMStartWatching;
		private DevComponents.DotNetBar.ButtonItem btnMMStopWatching;
		private DevComponents.DotNetBar.ButtonItem btnMMSynchronizeAll;
		private DevComponents.DotNetBar.ButtonItem btnMMExit;
		private DevComponents.DotNetBar.ButtonItem buttonItem10;
		private DevComponents.DotNetBar.ButtonItem btnMMConfiguration;
		private DevComponents.DotNetBar.ButtonItem buttonItem12;
		private DevComponents.DotNetBar.ButtonItem btnMMOnlineHelp;
		private DevComponents.DotNetBar.ButtonItem btnMMLicensing;
		private DevComponents.DotNetBar.ButtonItem btnMMAbout;
		private DevComponents.DotNetBar.Bar bar2;
		private DevComponents.DotNetBar.ButtonItem btnTBNew;
		private DevComponents.DotNetBar.ButtonItem btnTBEdit;
		private DevComponents.DotNetBar.ButtonItem btnTBSave;
		private System.Windows.Forms.ImageList imageList1;
		private DevComponents.DotNetBar.ButtonItem btnTBDelete;
		private DevComponents.DotNetBar.ButtonItem btnTBSynchronizeAll;
		private DevComponents.DotNetBar.ButtonItem btnTBOnlineHelp;
		private System.Windows.Forms.DataGridView gridJobs;
		private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.FolderBrowserDialog fbDialogSource;
    private System.Windows.Forms.FolderBrowserDialog fbDialogDestination;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		protected System.Windows.Forms.NotifyIcon notifyIcon1;
		private DevComponents.DotNetBar.ButtonItem MMVisitOurWebsite;
		private System.Windows.Forms.Panel panel1;
		private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ProgressBar pbProgress;
		private System.Windows.Forms.Label lblProgress;
		private LlamaCarbonCopy.Controls.LicenseControl licenseControl1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SourceLastChanged;
		private System.Windows.Forms.DataGridViewTextBoxColumn DestinationLastChanged;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Source;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
		private System.Windows.Forms.DataGridViewCheckBoxColumn WatchSubDirectories;
		private System.Windows.Forms.Label lblLoadingFiles;
		private DevComponents.DotNetBar.ButtonItem BIToolbarSynchAllJobs;
		private DevComponents.DotNetBar.ButtonItem BIToolbarSynchronizeSelectedJob;
		private DevComponents.DotNetBar.ButtonItem biMatch;
		private DevComponents.DotNetBar.ButtonItem biMatchAllJobs;
		private DevComponents.DotNetBar.ButtonItem biMatchSelectedJob;
        private System.Windows.Forms.Button btnLoadHistory;
	}
}

