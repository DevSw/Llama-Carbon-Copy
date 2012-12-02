using LlamaCarbonCopy.BusinessObject;
using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.IO;


namespace LlamaCarbonCopy.BusinessObject.Copier
{
	public interface ICopier 
	{
		void Copy(string original, string copy);
		void Copy(string original, string copy, bool overwrite);
	}

	public class SimpleCopy : ICopier
	{
		#region Constructors

		public SimpleCopy(){}	

		#endregion 

		#region ICopier Members

		public void Copy(string original, string copy)
		{
			this.Copy( original, copy, false );
		}

		public void Copy(string original, string copy, bool overwrite)
		{
			FileInfo fiOriginal = new FileInfo( original );
			fiOriginal.CopyTo( copy, overwrite );
			
			IReporter reporter = ReporterManager.GetReporter();
			reporter.AddReport( new ActionReportContainer( ActionType.Copy, ActionReportResult.Succeeded,
				"Copy succeeded",	original, copy) );			
		}

		#endregion
	}
}
