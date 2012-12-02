using LlamaCarbonCopy.BusinessObject.Reporter;
using LlamaCarbonCopy.BusinessObject.Singleton;
using LlamaCarbonCopy.Container;
using System;
using System.Collections;
using System.Net;

namespace LlamaCarbonCopy.BusinessObject
{
	public class EmailBO : BaseBO
	{
		public EmailBO() : base(){}

		public static void SendEmail(FolderMapContainer container)
		{
			string From = System.Configuration.ConfigurationSettings.AppSettings["EmailFrom"];
			string Body = "";
			if( container.BODY.Length > 0 )
			{
				Body = container.BODY;
			} 
			else 
			{
				Body = System.Configuration.ConfigurationSettings.AppSettings["EmailBody"] ;
			}
			string Subject = "";
			if( container.SUBJECT.Length > 0 )
			{
				Subject = container.SUBJECT;
			}
			else 
			{
				Subject = System.Configuration.ConfigurationSettings.AppSettings["EmailSubject"];
			}

			string SMTPServerName = System.Configuration.ConfigurationSettings.AppSettings["SMTPServerName"];
			string Username = System.Configuration.ConfigurationSettings.AppSettings["Username"];
			string Password = System.Configuration.ConfigurationSettings.AppSettings["Password"];

			string[] emails = new string[5];
			emails[0] = container.EMAIL1;
			emails[1] = container.EMAIL2;
			emails[2] = container.EMAIL3;
			emails[3] = container.EMAIL4;
			emails[4] = container.EMAIL5;

			foreach( string email in emails)
			{
				try
				{
					if( email.Length > 0 )
					{
						System.Web.Mail.MailMessage mmsg = new System.Web.Mail.MailMessage();
						mmsg.From = From;
						mmsg.To = email;
						mmsg.Body = Body;
						mmsg.Subject = Subject;
						System.Web.Mail.SmtpMail.SmtpServer = SMTPServerName;//"smtp.1and1.com";
						mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");	//basic authentication
						mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", Username); //set your username here
						mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", Password);	//set your password here
						System.Web.Mail.SmtpMail.Send(mmsg);
					}
				} 
				catch (Exception)
				{
					IReporter reporter = ReporterManager.GetReporter();
					reporter.AddReport( new ActionReportContainer( ActionType.Notify, ActionReportResult.Failed, "Email notification to " +
						email + " failed"));
				}
			}			
		}

		public static void SendAdminEmail(string EmailBody){}
	}
}
