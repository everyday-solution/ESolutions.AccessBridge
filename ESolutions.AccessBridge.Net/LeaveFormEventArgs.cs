using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet
{
	/// <summary>
	/// Delegate for the LeaveFormEvent
	/// </summary>
	/// <param name="sender">The sender.</param>
	/// <param name="e">The <see cref="LeaveFormEventArgs" /> instance containing the event data.</param>
	public delegate void LeaveFormHandler(object sender,
		LeaveFormEventArgs e);

	/// <summary>
	/// EventArgs when leaving form.
	/// </summary>
	/// <seealso cref="System.EventArgs" />
	public class LeaveFormEventArgs : EventArgs
	{
		//Properties
		#region ReturnValue
		/// <summary>
		/// Gets or sets the return value. String.Empty means: nothing.
		/// </summary>
		/// <value>
		/// The return value.
		/// </value>
		public String ReturnValue
		{
			get;
			set;
		}
		#endregion

		//Constructors
		#region LeaveFormEventArgs
		/// <summary>
		/// Initializes a new instance of the <see cref="LeaveFormEventArgs"/> class.
		/// </summary>
		/// <param name="returnvalue">The returnvalue.</param>
		public LeaveFormEventArgs(String returnvalue)
		{
			this.ReturnValue = returnvalue;
		}
		#endregion
	}
}
