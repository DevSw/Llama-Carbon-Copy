using LlamaCarbonCopy.BusinessObject.Reporter;
using System;
using System.Collections;
using System.Reflection;

namespace LlamaCarbonCopy.BusinessObject.Singleton
{	
	/// <summary>
	/// Manages the singletons by type.  Allows only a single instance of a
	/// specific type.  Creates an instance of the type you require if one is 
	/// not present.  This ensures that multiple uses of the same type of class are
	/// not present.  
	/// </summary>
	public class SingletonManager
	{
		#region Constructors

		#endregion

		#region Variables

		#region SINGLETONHASH Property definitions

		private static Hashtable singletonhash = new Hashtable();
		//private bool singletonhashchanged;

		/*
		public Hashtable SINGLETONHASH 
		{
			get{ return singletonhash;}
			set
			{ 
				singletonhash = value;
				//singletonhashchanged = true;
				OnSINGLETONHASHChanged();
			}
		}

		protected void OnSINGLETONHASHChanged()
		{
			EventHandler ev = this.SINGLETONHASHChanged;
			if( ev != null)
				ev(this, EventArgs.Empty);
		}

		public event EventHandler SINGLETONHASHChanged; */
		#endregion

		#endregion

		#region public methods

		/// <summary>
		/// Returns the singleton of the given type.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static object GetSingleton(Type type)
		{
			lock( SingletonManager.singletonhash.SyncRoot )
			{
				object single = SingletonManager.singletonhash[type];
				if( single == null )
				{
					
					single = Activator.CreateInstance(type);
					SingletonManager.singletonhash.Add(type, single);
				}
				return single;
			}			
		}

		/// <summary>
		/// Used to insert a singleton into the manager.  It should be noted
		/// that if a singleton of that type already exists, it won't be inserted.
		/// </summary>
		/// <param name="singleton"></param>
		public static void SetSingleton(object singleton)
		{
			if( !SingletonManager.Contains( singleton.GetType() ) )
			{
				SingletonManager.singletonhash.Add(singleton.GetType(), singleton);
			} 
		}

		/// <summary>
		/// public method to determine if a singleton of that type already exists in the manager.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool Contains(Type type)
		{
			return SingletonManager.singletonhash.Contains(type);
		}

		#endregion
	}

	public class ReporterManager
	{
		#region Vars

		private static IReporter reporter;

		#endregion 

		#region Public Static Methods

		public static IReporter GetReporter()
		{
			if( reporter == null ) reporter = new BusinessObject.Reporter.FirstReporter();
			return reporter;
		}
		#endregion 
	}
}



