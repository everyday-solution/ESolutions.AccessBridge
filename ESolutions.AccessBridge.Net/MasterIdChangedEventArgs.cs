using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet
{
	public class MasterIdChangedEventArgs
	{
		//Properties
		#region MasterId
		/// <summary>
		/// Gets the master identifier.
		/// </summary>
		/// <value>
		/// The master identifier.
		/// </value>
		public Int32 MasterId
		{
			get;
			private set;
		}
		#endregion

		//Constructors
		#region MasterIdChangedEventArgs
		/// <summary>
		/// Initializes a new instance of the <see cref="MasterIdChangedEventArgs"/> class.
		/// </summary>
		/// <param name="masterId">The master identifier.</param>
		public MasterIdChangedEventArgs(Int32 masterId)
		{
			this.MasterId = masterId;
		}
		#endregion
	}
}
