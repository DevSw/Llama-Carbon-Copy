using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections;
using System.IO;

namespace LlamaCarbonCopy.BusinessObject.Reporter
{
	public interface IReporter 
	{
		bool HasReport();
		void AddReport(ActionReportContainer container);		
		ActionReportContainer[] GetFullReport();	
		void ResetReport();
	}	

	public class FirstReporter : IReporter
	{
		#region Report Property Definitions
		protected ArrayList report;
		protected bool reportchanged;
		public ArrayList Report 
		{
			get 
			{
				return report;
			}
			set 
			{
				report = value;
				reportchanged = true;
				OnReportChanged();
			}
		}
		protected void OnReportChanged ()
		{
			EventHandler ev = this.ReportChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler ReportChanged;
		#endregion

		#region Constructors

		public FirstReporter()
		{
			this.SyncRoot = new object();
			this.report = new ArrayList();
		}

		#endregion 

		#region IReporter Members

		public bool HasReport()
		{
			return 	this.report.Count > 0;
		}

		public void ResetReport()
		{
			this.report.Clear();
		}

		public void AddReport(ActionReportContainer container)
		{
			this.report.Add( container );

			WriteLog(container);
			if( container.ActionResult != ActionReportResult.Noted )
			{
				//FileHistoryBO.WriteFileHistory( container );
				//TODO: FirstReporter.AddReport()
			}
		}

		public ActionReportContainer[] GetFullReport()
		{
			ActionReportContainer[] arry = new ActionReportContainer[this.report.Count];
			int i = 0;
			foreach( ActionReportContainer container in this.report)
			{
				arry[i++] = container;
			}
			return arry;
		}

		#endregion

		#region Private Methods

		private object SyncRoot;

		private void WriteLog(ActionReportContainer container)
		{
			ConfigurationBO cbo = (ConfigurationBO)SingletonManager.GetSingleton(typeof(ConfigurationBO));
			string logfile = SharedBO.GetLogFile();
			StreamWriter sw = null;
			
			FileInfo fi = new FileInfo( logfile );
			lock (this.SyncRoot)
			{
				try 
				{
					sw = fi.AppendText();

					if( container.OriginalPath.CompareTo("") != 0 )	sw.WriteLine( "File: \t\t" + container.OriginalPath );
					if( container.CopyPath.CompareTo("") != 0 ) sw.WriteLine( "Copy to:\t" + container.CopyPath );
					sw.WriteLine( "Action: \t\t" + container.Action.ToString() );
					sw.WriteLine( "Result: \t\t" + container.ActionResult.ToString() );
					sw.WriteLine( "Comment:\t" + container.ActionResultDescription );
					sw.WriteLine( "Occured at:\t" + container.OccuredAt.ToString("f"));
					sw.Flush();
			
				} 
				catch (Exception)
				{
					//TODO: IReporter.FirstReporter.WriteLog()
					//System.Windows.Forms.Form eForm = new LlamaCarbonCopy.Controls.Forms.ErrorMessageForm(
					//  String.Format(
					//  OBBO.blah(),
					//  logfile),
					//  OBBO.err()
					//  );
					//eForm.ShowDialog();
				}
				finally 
				{
					if( sw != null) sw.Close();
				}
			}
		}

		//private void WriteToDb(ActionReportContainer container)
		//{
		//  //FileHistoryContainer fhcontainer = new FileHistoryContainer();
		//  //fhcontainer.COPYDATE = container.OccuredAt;
		//  //int FileID = FileIdTuple.Instance().GetFileId(container.OriginalPath);
		//  //if( FileID == -1 )
		//  //{
				
		//  //  FileListBO fbo = (FileListBO)SingletonManager.GetSingleton(typeof(FileListBO));
		//  //  FileContainer fcontainer = new FileContainer();
		//  //  fcontainer.NAME = container.OriginalPath;
		//  //  fbo.AddFile( fcontainer );
		//  //}
			
		//  //FileID = FileIdTuple.Instance().GetFileId(container.OriginalPath);
		//  //if( FileID != -1 )
		//  //{
		//  //  fhcontainer.FILEID = FileID;
		//  //  fhcontainer.FILESTATUSID = FileStatusIdTuple.Instance().GetFileStatusId( container.ActionResult.ToString() );
		//  //  fhcontainer.FILEACTIONID = FileActionIdTuple.Instance().GetFileActionId( container.Action.ToString() );
		//  //  FileHistoryConnection fhconn = (FileHistoryConnection)SingletonManager.GetSingleton(typeof(FileHistoryConnection));
		//  //  fhconn.InsertFileHistory( fhcontainer );
		//  //}		
		//}
		#endregion
	}

	public class SynchronizeReporter : IReporter
	{
		#region Report Property Definitions
		protected ArrayList report;
		protected bool reportchanged;
		public ArrayList Report 
		{
			get 
			{
				return report;
			}
			set 
			{
				report = value;
				reportchanged = true;
				OnReportChanged();
			}
		}
		protected void OnReportChanged ()
		{
			EventHandler ev = this.ReportChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler ReportChanged;
		#endregion

		#region Constructors

		public SynchronizeReporter()
		{
			this.report = new ArrayList();
		}

		#endregion 

		#region IReporter Members

		public bool HasReport()
		{
			return this.report.Count > 0 ;
		}

		public void AddReport(ActionReportContainer container)
		{
			lock (this.report.SyncRoot )
			{
				this.report.Add( container );
			}
		}

		public ActionReportContainer[] GetFullReport()
		{
			lock (this.report.SyncRoot)
			{
				ActionReportContainer[] arry = new ActionReportContainer[this.report.Count];
				int i = 0;
				foreach( ActionReportContainer container in this.report)
				{
					arry[i++] = container;
				}
				return arry;
			}
		}


		public void ResetReport()
		{
			lock( this.report.SyncRoot)
			{
				this.report.Clear();
			}
		}

		#endregion
	}
}
