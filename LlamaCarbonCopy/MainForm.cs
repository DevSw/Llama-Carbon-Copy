using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using LlamaCarbonCopy.Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LlamaCarbonCopy {
	public partial class MainForm : Form {
    public MainForm() { InitializeComponent(); }
    private void Form1_Load(object sender, EventArgs e) {
			VersionBO vbo = (VersionBO)SingletonManager.GetSingleton(typeof(VersionBO));
			this.Text = vbo.ProgramName + " v" + vbo.Version;
			LoadJobs();
			//RefreshFiles();
			ConfigurationBO bo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			ListenerBO lbo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
			if (bo.CContainer.AutoStart)  lbo.StartListeners();
			lbo.StatusChanged += new EventHandler(lbo_StatusChanged);
			lbo_StatusChanged(lbo, EventArgs.Empty);
			SynchronizeBO sbo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			sbo.Synchronized += new SynchEventHandler(sbo_Synchronized);
			sbo.FinishedSynch += new EventHandler(sbo_FinishedSynch);
		}

		#region Synchronization Handlers
		private object SynchLock = new object();
		void sbo_FinishedSynch(object sender, EventArgs e) {
			//lock (SynchLock) {
			finished += new EventHandler(t);
			this.Invoke(finished);
			//}
		}
		private event EventHandler finished;
		private void t(object sender, EventArgs a) {
			lblProgress.Text = "Synchronization Finished";
			pbProgress.Visible = false;
			//RefreshFiles();
		}
		private event SynchEventHandler progressed;
		private void s(object sender, SynchEventHandlerArgs a) {
			pbProgress.Maximum = a.total;
			lblProgress.Text = a.action;
			pbProgress.Value = a.completed;
		}
		void sbo_Synchronized(object sender, SynchEventHandlerArgs args) {
			progressed += new SynchEventHandler(s);
			this.Invoke(progressed, this, args);
		}
		#endregion 

		#region Status Changed
		void lbo_StatusChanged(object sender, EventArgs e) {
			ListenerBO lbo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
			if (lbo.Started) {
				lblStatus.ForeColor = Color.DarkGreen;
				lblStatus.Text = "Status: Active";
			}
			else {
				lblStatus.ForeColor = Color.DarkRed;
				lblStatus.Text = "Status: Inactive";
			}
		}
		#endregion

		#region New
		private void btnTBNew_Click(object sender, EventArgs e) { New(); }
    private void btnMMNew_Click(object sender, EventArgs e) { New(); }
    private void New() { 
			int i = gridJobs.Rows.Add();
			gridJobs.Rows[i].Selected = true;
			gridJobs.CurrentCell = gridJobs.SelectedRows[0].Cells[0];
		}
    #endregion

    #region Edit
    private void btnTBEdit_Click(object sender, EventArgs e) { Edit(); }
    private void btnMMEdit_Click(object sender, EventArgs e) { Edit(); }
    private void Edit() {
			DataGridViewRow row = GetSelectedRowFromCell(gridJobs);
			if (row == null) return;
			gridJobs.CurrentCell = row.Cells[0];
		}
    #endregion

    #region Copy
    private void btnTBSave_Click(object sender, EventArgs e) { Copy(); }
    private void btnMMCopy_Click(object sender, EventArgs e) { Copy();}
    private void Copy() {
			DataGridViewRow row = GetSelectedRowFromCell(gridJobs);
			if (row == null) return;
			DataGridViewRow copy = (DataGridViewRow)row.Clone();
			for (int i = 0; i < row.Cells.Count; i++) copy.Cells[i].Value = row.Cells[i].Value;
			copy.Cells[0].Value = "Copy Of " + copy.Cells[0].Value.ToString();
			gridJobs.Rows.Add(copy);
			foreach(DataGridViewRow grow in gridJobs.Rows)
				grow.Selected = false;
			copy.Selected = true;
			SaveJob(gridJobs, copy.Index);
		}

    #endregion

    #region Delete
    private void btnMMDelete_Click(object sender, EventArgs e) { Delete(); }
    private void btnTBDelete_Click(object sender, EventArgs e) {
      Delete();
    }
    private void Delete() {
			QuestionForm frm = new QuestionForm();
			frm.Msg = "Delete this job?";
			if (frm.ShowDialog() == DialogResult.OK) {
				DataGridViewRow row = GetSelectedRowFromCell(gridJobs);
				if (row == null) return;
				gridJobs.Rows.Remove(row);
				if (row.Cells[0].Value == null) {
					//RefreshFiles();
                    ClearFiles();
					return;
				}
				string name = row.Cells[0].Value.ToString();
				JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
				JobContainer container = bo.FindByName(name);
				if (container != null) {
					bo.Delete(container);
					bo.Save();
					//RefreshFiles();
				}
			}
		}
    #endregion

    #region Synch all
    private void btnTBSynchronizeAll_Click(object sender, EventArgs e) { SynchronizeAll(); }
    private void btnMMSynchronizeAll_Click(object sender, EventArgs e) { SynchronizeAll(); }
		private void BIToolbarSynchAllJobs_Click(object sender, EventArgs e) { SynchronizeAll(); }			
    private void SynchronizeAll() {
			pbProgress.Visible = true;
			lblProgress.Visible = true;			
			SynchronizeBO bo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			bo.aSynchronizeAll();
		}
		private void BIToolbarSynchronizeSelectedJob_Click(object sender, EventArgs e) {
			pbProgress.Visible = true;
			lblProgress.Visible = true;			
			DataGridViewRow row = GetSelectedRowFromCell(this.gridJobs);
			if (row != null) {
				JobsBO jbo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
				JobContainer container = jbo.FindByName(row.Cells[0].Value.ToString());
				if (container != null) {
					SynchronizeBO bo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
					bo.aSynchronizeDirectory(
						container.SourceDirectory,
						container.SourceDirectory,
						container.DestinationDirectory,
						container.WatchSubDirectories, 
						false);
					//RefreshFiles();
				}
			}
			else {
				MessageForm frm = new MessageForm();
				frm.Msg = "No job was selected, please select a job by click on its name and try again.";
				frm.ShowDialog();
			}
		}
    #endregion

    #region Online Help
    private void btnTBOnlineHelp_Click(object sender, EventArgs e) { Help(); }
    private void btnMMOnlineHelp_Click(object sender, EventArgs e) { Help(); }
		private void Help() { SharedBO.LaunchHelp(); }
    #endregion

		#region Main Menu Handlers
    private void btnMMStartWatching_Click(object sender, EventArgs e) {
			ListenerBO bo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
			bo.StartListeners();
    }
    private void btnMMStopWatching_Click(object sender, EventArgs e) {
			ListenerBO bo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
			bo.StopListeners();
    }
    private void btnMMExit_Click(object sender, EventArgs e) {
			ListenerBO bo = (ListenerBO)SingletonManager.GetSingleton(typeof(ListenerBO));
			bo.StopListeners();						
			JobsBO jbo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
			jbo.Save();
			ConfigurationBO cbo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			cbo.Save();
			//this.Close();
			Application.Exit();			
    }
    private void btnMMConfiguration_Click(object sender, EventArgs e) {
			ConfigurationForm frm = new ConfigurationForm();
			frm.ShowDialog();
    }
    private void btnMMLicensing_Click(object sender, EventArgs e) {
			LicenseBO bo = (LicenseBO)SingletonManager.GetSingleton(typeof(LicenseBO));
			bo.AttemptLicense(); 
    }
    private void btnMMAbout_Click(object sender, EventArgs e) {
			AboutForm frm = new AboutForm();
			frm.ShowDialog();
		}
		private void btnMMVisitOurWebsite_Click(object sender, EventArgs e) {
			SharedBO.LaunchWebsite(Properties.Settings.Default.Website);
		}
#endregion

		#region Grid handlers
		private void gridJobs_CellEnter(object sender, DataGridViewCellEventArgs e) { HandleCellFocus(sender, e); }
    private void gridJobs_CellClick(object sender, DataGridViewCellEventArgs e) { HandleCellFocus(sender, e); }
    private void HandleCellFocus(object sender, DataGridViewCellEventArgs e) {			
			if (e.RowIndex < 0) return;
      if (e.ColumnIndex == 1) {
        //MessageBox.Show("Entered source column");
        if (gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
          gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().CompareTo("") != 0) {
          fbDialogSource.SelectedPath = gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        if (DialogResult.OK == fbDialogSource.ShowDialog()) {
          gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fbDialogSource.SelectedPath;					
					SaveJob((DataGridView)sender, e.RowIndex);
					//RefreshFiles();
        }
      }
      else if (e.ColumnIndex == 2) {
        if (gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
          gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().CompareTo("") != 0) {
          fbDialogDestination.SelectedPath = gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
        if (DialogResult.OK == fbDialogDestination.ShowDialog()) {
          gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fbDialogDestination.SelectedPath;
					SaveJob((DataGridView)sender, e.RowIndex);
        }
			}
			/*else if (e.ColumnIndex == 3) { SaveJob((DataGridView)sender, e.RowIndex); }			*/
		}
		private void gridJobs_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
			if (e.ColumnIndex == 0 &&
				gridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString().CompareTo("") == 0) {
				DataGridViewRow row = gridJobs.Rows[e.RowIndex];
				MessageForm frm = new MessageForm();
				frm.Msg = "A unique name must be entered for each job.  Please enter a unique name for this job.";
				frm.ShowDialog();
				e.Cancel = true;
			}
			else SaveJob(gridJobs, e.RowIndex);
		}
		private void gridJobs_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex < 0) return;
			if (e.ColumnIndex == 3) {
				SaveJob((DataGridView)sender, e.RowIndex);
				//RefreshFiles();
			}
		}	
		#endregion

		#region Private methods
		private void SaveJob(DataGridView dgv, int rowIndex) {
			if (dgv.Rows.Count < rowIndex - 1) return;
			DataGridViewRow row = dgv.Rows[rowIndex];									
			if (row.Cells[0].Value != null &&
				row.Cells[1].Value != null &&
				row.Cells[2].Value != null &&
				//row.Cells[3].Value != null &&
				row.Cells[0].Value.ToString().CompareTo("") != 0 &&
				row.Cells[1].Value.ToString().CompareTo("") != 0 &&
				row.Cells[2].Value.ToString().CompareTo("") != 0 /*&&
				row.Cells[3].Value.ToString().CompareTo("") != 0*/) { 
				//ok to save
				JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
				JobContainer container = bo.FindByName(row.Cells[0].Value.ToString());
				if (container == null) {
					JobContainer container2 = new JobContainer();
					container2.Name = row.Cells[0].Value.ToString();
					bo.Add(container2);
					container = bo.FindByName(row.Cells[0].Value.ToString());
				}
				container.SourceDirectory = row.Cells[1].Value.ToString();
				container.DestinationDirectory = row.Cells[2].Value.ToString();
				container.WatchSubDirectories = (bool)row.Cells[3].EditedFormattedValue;
				bo.Save();
			}
		}
		private void LoadJobs() {
			DataGridViewRow row = GetSelectedRowFromCell(gridJobs);
			string focused_name = "";
			if( row != null) row.Cells["Name"].Value.ToString();
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));			
			gridJobs.Rows.Clear();
			if (bo.JContainer.Jobs.Count == 0) return;
			foreach (JobContainer container in bo.JContainer.Jobs) {
				object[] objs = { container.Name, container.SourceDirectory, container.DestinationDirectory, 
					container.WatchSubDirectories};
				gridJobs.Rows.Add(objs);
			}
			FocusRow(focused_name, gridJobs);
		}
		private void FocusRow(string name, DataGridView dgv) {
			if (name.Length == 0) return;
			foreach (DataGridViewRow row in dgv.Rows)
				if (row.Cells["Name"].Value.ToString().CompareTo(name) == 0) row.Selected = true;
				else row.Selected = false;
		}
		private DataGridViewRow GetSelectedRowFromCell(DataGridView dgv) {
			if (dgv.SelectedCells.Count > 0) {
				DataGridViewCell cell = dgv.SelectedCells[0];
				return dgv.Rows[cell.RowIndex];
			}
			return null;
		}
		private void RefreshFiles() {
			if (gridJobs.Rows.Count == 0) {
				dataGridView1.Rows.Clear();
				return;
			}
			DataGridViewRow row = GetSelectedRowFromCell(gridJobs);
			if (row == null || row.Cells[0].Value == null) return;
			lblLoadingFiles.Visible = true;
			JobsBO bo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
			JobContainer container = bo.FindByName(row.Cells[0].Value.ToString());
			if (container != null) {
				FileRefresher fr = new FileRefresher(container);
				fr.dataGridView1 = dataGridView1;
				fr.Finished += new FileRefresherFinishedEventHandler(fr_Finished);
				LatestJobForFiles = container;
				fr.Run();				
			}
		}
        private void ClearFiles() {
            if (gridJobs.Rows.Count == 0)
            {
                dataGridView1.Rows.Clear();
                return;
            }
        }
		private JobContainer LatestJobForFiles;
		void fr_Finished(object sender, FileRefresherFinishedEventArgs args) {
			this.Invoke(new Empty(delegate() {				
				if (	args.Container != null &&
							this.LatestJobForFiles != null &&
							LatestJobForFiles.Name.CompareTo(args.Container.Name) == 0) {
					this.dataGridView1.Rows.Clear();
					lblLoadingFiles.Visible = false;
					dataGridView1.SuspendLayout();
					dataGridView1.Rows.AddRange(args.Rows.ToArray());
					dataGridView1.ResumeLayout();
				}
			}));		
		}
		
		
		#endregion

		#region Form Minimize to System Tray
		private void notifyIcon1_Click(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				this.Visible = true;
				//this.ShowInTaskbar = true;
				this.notifyIcon1.Visible = false;
				this.WindowState = FormWindowState.Normal;
				//this.Refresh();
			}
		}

		private void MainForm_SizeChanged(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				this.Visible = false;
				//this.ShowInTaskbar = false;
				this.notifyIcon1.Visible = true;
			}
		}
		#endregion

		private int OldCurrentRowIndex = -1;
		private void gridJobs_CurrentCellChanged(object sender, EventArgs e) {
			if (gridJobs.CurrentCell != null && gridJobs.CurrentCell.RowIndex != OldCurrentRowIndex) {
				OldCurrentRowIndex = gridJobs.CurrentCell.RowIndex;
				//changed row
				//RefreshFiles();
			}
		}
		private void MainForm_Activated(object sender, EventArgs e) { 
            //RefreshFiles(); 
        }
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				e.Cancel = true;
				this.WindowState = FormWindowState.Minimized;
			}
			else {
				JobsBO jbo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
				jbo.Save();
			}
		}

		#region Match
		private void biMatch_Click(object sender, EventArgs e) { MatchAll(); }
		private void biMatchAllJobs_Click(object sender, EventArgs e) { MatchAll(); }
		private bool MatchWarn() {
			QuestionForm frm = new QuestionForm();
			frm.Msg = "WARNING:  This process can delete files from your backup.  "+
				"It will remove any files or folders that do not currently exist in your source directory(s).\n\n" +
				"Are you sure you want to proceed?";
			return DialogResult.OK == frm.ShowDialog();
		}
		private void MatchAll() {
			if (!MatchWarn()) return;
			pbProgress.Visible = true;
			lblProgress.Visible = true;
			SynchronizeBO bo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
			bo.aMatchAll();
		}
		private void biMatchSelectedJob_Click(object sender, EventArgs e) {
			if (!MatchWarn()) return;
			pbProgress.Visible = true;
			lblProgress.Visible = true;
			DataGridViewRow row = GetSelectedRowFromCell(this.gridJobs);
			if (row != null) {
				JobsBO jbo = (JobsBO)SingletonManager.GetSingleton(typeof(JobsBO));
				JobContainer container = jbo.FindByName(row.Cells[0].Value.ToString());
				if (container != null) {
					SynchronizeBO bo = (SynchronizeBO)SingletonManager.GetSingleton(typeof(SynchronizeBO));
					bo.aSynchronizeDirectory(
						container.SourceDirectory,
						container.SourceDirectory,
						container.DestinationDirectory,
						container.WatchSubDirectories,
						true);
					//RefreshFiles();
				}
			}
			else {
				MessageForm frm = new MessageForm();
				frm.Msg = "No job was selected, please select a job by click on its name and try again.";
				frm.ShowDialog();
			}
		}
		#endregion

        private void btnLoadHistory_Click(object sender, EventArgs e) { RefreshFiles(); }


	}
	public delegate void Empty();
	public class FileRefresher {
		public JobContainer container;
		public DataGridView dataGridView1;
		public List<DataGridViewRow> results;
		public FileRefresher(JobContainer jcon) { container = jcon; }
		public void inner_run() {
			List<string> files = GetAllFiles(container.SourceDirectory, new List<string>(), container.WatchSubDirectories);
			List<List<object>> lrows = new List<List<object>>();
			List<DataGridViewRow> drows = new List<DataGridViewRow>();
			foreach (string file in files) {
				try {
					string dfile = SharedBO.CalculateDestination(container.SourceDirectory, file, container.DestinationDirectory);//Path.Combine(container.DestinationDirectory, Path.GetFileName(file));
					FileInfo fi_file = new FileInfo(file);
					try {
						FileInfo fi_dfile = new FileInfo(dfile);
						DataGridViewRow rw = new DataGridViewRow();
						rw.CreateCells(dataGridView1, SharedBO.CalculateDestination(container.SourceDirectory, file, ""),
							fi_file.LastWriteTime, fi_dfile.LastWriteTime,
							fi_file.LastWriteTime <= fi_dfile.LastWriteTime ? "Up To Date" : "Outdated");
						drows.Add(rw);
					}
					catch (System.IO.FileNotFoundException) {
						DataGridViewRow rw = new DataGridViewRow();
						rw.CreateCells(dataGridView1, SharedBO.CalculateDestination(container.SourceDirectory, file, ""),
							fi_file.LastWriteTime, "---", "Outdated");
						drows.Add(rw);
					}
				}
				catch { }
			}
			OnFinished(new FileRefresherFinishedEventArgs(drows, container));
		}
		public void Run() {
			System.Threading.Thread myThread = new System.Threading.Thread(new System.Threading.ThreadStart(inner_run));
			myThread.IsBackground = true;
			myThread.Start();			
		}
		public event FileRefresherFinishedEventHandler Finished;
		private void OnFinished(FileRefresherFinishedEventArgs args){
			FileRefresherFinishedEventHandler ev = Finished;
			if (ev != null) ev(this, args);
		}
		private List<string> GetAllFiles(string dir, List<string> lst, bool includeSubfolders) {
			if (!Directory.Exists(dir)) return lst;
			try {
				lst.AddRange(Directory.GetFiles(dir));
				if (includeSubfolders)
					foreach (string subdir in Directory.GetDirectories(dir))
						GetAllFiles(subdir, lst, includeSubfolders);
				return lst;
			}
			catch {
				return lst;
			}
		}
	}
	public delegate void FileRefresherFinishedEventHandler(object sender, FileRefresherFinishedEventArgs args);
	public class FileRefresherFinishedEventArgs : System.EventArgs { 
		public List<DataGridViewRow> Rows;
		public JobContainer Container;
		public FileRefresherFinishedEventArgs(List<DataGridViewRow> rows, JobContainer container) { Rows = rows; Container = container; }
	}
}

//TODO: finish adding the form that will allow someone to easily select the files they wanted backed up.