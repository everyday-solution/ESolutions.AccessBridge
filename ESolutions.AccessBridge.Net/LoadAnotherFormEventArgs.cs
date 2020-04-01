using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet
{
	/// <summary>
	/// Delegate for the event LeaveFormEvent
	/// </summary>
	/// <param name="sender">The sender.</param>
	/// <param name="e">The <see cref="LoadAnotherFormEventArgs"/> instance containing the event data.</param>
	public delegate void LoadAnotherFormHandler(object sender,
		 LoadAnotherFormEventArgs e);

	/// <summary>
	/// Arguments, die beim schlieﬂen des Forms mitgefeuert werden
	/// </summary>
	public class LoadAnotherFormEventArgs : EventArgs
	{
		//Properties
		#region AssemblyName
		public String AssemblyName
		{
			get;
			set;
		}
		#endregion

		#region FormTypeName
		/// <summary>
		/// Gets or sets the name of the form type.
		/// </summary>
		/// <value>
		/// The name of the form type.
		/// </value>
		public String FormTypeName
		{
			get;
			set;
		}
		#endregion

		//Constructors
		#region LoadAnotherFormEventArgs
		/// <summary>
		/// Initializes a new instance of the <see cref="LoadAnotherFormEventArgs"/> class.
		/// </summary>
		/// <param name="namespaceName">Name of the namespace.</param>
		/// <param name="formName">Name of the form.</param>
		public LoadAnotherFormEventArgs(
			String assemblyName,
			String formTypeName)
		{
			this.AssemblyName = assemblyName;
			this.FormTypeName = formTypeName;
		}
		#endregion
	}
}
