using System;

namespace LlamaCarbonCopy.Container
{
	public class ActionReportContainer 
	{
		#region Action Property Definitions
		protected ActionType action;
		protected bool actionchanged;
		public ActionType Action 
		{
			get 
			{
				return action;
			}
			set 
			{
				action = value;
				actionchanged = true;
				OnActionChanged();
			}
		}
		protected void OnActionChanged ()
		{
			EventHandler ev = this.ActionChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler ActionChanged;
		#endregion

		#region ActionResult Property Definitions
		protected ActionReportResult actionresult;
		protected bool actionresultchanged;
		public ActionReportResult ActionResult 
		{
			get 
			{
				return actionresult;
			}
			set 
			{
				actionresult = value;
				actionresultchanged = true;
				OnActionResultChanged();
			}
		}
		protected void OnActionResultChanged ()
		{
			EventHandler ev = this.ActionResultChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler ActionResultChanged;
		#endregion

		#region ActionResultDescription Property Definitions
		protected string actionresultdescription;
		protected bool actionresultdescriptionchanged;
		public string ActionResultDescription 
		{
			get 
			{
				return actionresultdescription;
			}
			set 
			{
				actionresultdescription = value;
				actionresultdescriptionchanged = true;
				OnActionResultDescriptionChanged();
			}
		}
		protected void OnActionResultDescriptionChanged ()
		{
			EventHandler ev = this.ActionResultDescriptionChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler ActionResultDescriptionChanged;
		#endregion

		#region OriginalPath Property Definitions
		protected string originalpath;
		protected bool originalpathchanged;
		public string OriginalPath 
		{
			get 
			{
				return originalpath;
			}
			set 
			{
				originalpath = value;
				originalpathchanged = true;
				OnOriginalPathChanged();
			}
		}
		protected void OnOriginalPathChanged ()
		{
			EventHandler ev = this.OriginalPathChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler OriginalPathChanged;
		#endregion

		#region CopyPath Property Definitions
		protected string copypath;
		protected bool copypathchanged;
		public string CopyPath 
		{
			get 
			{
				return copypath;
			}
			set 
			{
				copypath = value;
				copypathchanged = true;
				OnCopyPathChanged();
			}
		}
		protected void OnCopyPathChanged ()
		{
			EventHandler ev = this.CopyPathChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler CopyPathChanged;
		#endregion

		#region OccuredAt Property Definitions
		protected DateTime occuredat;
		protected bool occuredatchanged;
		public DateTime OccuredAt 
		{
			get 
			{
				return occuredat;
			}
			set 
			{
				occuredat = value;
				occuredatchanged = true;
				OnOccuredAtChanged();
			}
		}
		protected void OnOccuredAtChanged ()
		{
			EventHandler ev = this.OccuredAtChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
		public event EventHandler OccuredAtChanged;
		#endregion
		
		#region Constructors

		public ActionReportContainer()
		{
			this.occuredat = DateTime.Now;
		}

		public ActionReportContainer(ActionType actionType, ActionReportResult arResult, string description) :
			this(actionType, arResult, description, "",""){}

		public ActionReportContainer(ActionType actionType, ActionReportResult arResult, string description, string original, string copy) :
			this()
		{
			this.action = actionType;
			this.actionresult = arResult;
			this.actionresultdescription = description;
			this.originalpath = original;
			this.copypath = copy;
		}	
		#endregion 
	}

	public enum ActionType {Copy, Synchronize, Notify, Rename, Delete};
	public enum ActionReportResult {Failed, Succeeded, Delayed, Noted};
}
