using System;
using System.Collections;

namespace LlamaCarbonCopy.BusinessObject.Collections
{
	/// <summary>
	/// Thread safe Hashtable.
	/// </summary>
	public class LockedHashtable
	{
		#region Variables

		protected Hashtable hash;

		#endregion

		#region Constructor
		public LockedHashtable()
		{
			this.hash = new Hashtable();
		}
		#endregion

		#region Public methods


		public void Add(object Key, object Value)
		{
			lock(this.hash.SyncRoot)
			{
				this.hash.Add( Key, Value );
			}
		}

		public void Remove(object Key)
		{
			lock(this.hash.SyncRoot)
			{
				this.hash.Remove(Key);
			}
		}

		public bool Contains(object Key)
		{
			lock(this.hash.SyncRoot)
			{
				return this.hash.Contains(Key);
			}
		}

		public object this[object Key]
		{
			get
			{
				lock(this.hash.SyncRoot)
				{
					return this.hash[Key];
				}
			}
			set
			{
				lock(this.hash.SyncRoot)
				{
					this.hash[Key] = value;
				}
			}
		}

		public ICollection GetKeys()
		{
			return this.hash.Keys;
		}

		public ICollection GetValues()
		{
			return this.hash.Values;
		}

		#endregion
	}
}
