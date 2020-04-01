using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet
{
	/// <summary>
	/// Interface for forms that can be displayed as a part of the access application.
	/// </summary>
	public interface IForm
	{
		#region Initialize
		/// <summary>
		/// Initializes the form with the global application settings
		/// </summary>
		/// <param name="settings">The settings.</param>
		void Initialize(ESolutions.AccessBridge.DotNet.Common.ApplicationSettings settings);
		#endregion

		#region PutSettings
		/// <summary>
		/// Put settings into form.
		/// </summary>
		/// <param name="Parameter1">The parameter1.</param>
		/// <param name="Parameter2">Übergabeparameter an das Form</param>
		/// <param name="canSave">if set to <c>true</c> [can save].</param>
		/// <param name="canPrint">if set to <c>true</c> [can print].</param>
		void PutSettings(
			String Parameter1,
			String Parameter2,
			ref Boolean canSave,
			ref Boolean canPrint);
		#endregion

		#region MasterIdChanged
		/// <summary>
		/// Accord ti PersonAusgewehlt-Methode in AccessForms. Occurs each time an inhabitant is choosen
		/// in the inhabitant-selection-control.
		/// </summary>
		/// <param name="inhabitantId">The inhabitant id.</param>
		/// <param name="forename">The forename.</param>
		/// <param name="familyname">The familyname.</param>
		/// <param name="icon">The group in which the choosen inhabitant resists..</param>
		void MasterIdChanged(MasterIdChangedEventArgs e);
		#endregion

		#region LeaveForm
		/// <summary>
		/// Das Event muss gefeuert werden, wenn das Formular verlassen werden soll. Das Formular darf NICHT 
		/// mit Form.Close () geschlossen werden.
		/// </summary>
		event LeaveFormHandler LeaveForm;
		#endregion

		#region LoadAnotherForm
		/// <summary>
		/// Das Event muss gefeuert werden, wenn ein weiteres Formular (als Unterformular) geladen werden soll.
		/// </summary>
		event LoadAnotherFormHandler LoadAnotherForm;
		#endregion

		#region Show
		/// <summary>
		/// Shows the dorm in a non modal way.
		/// </summary>
		void Show();
		#endregion

		#region Close
		/// <summary>
		/// CLoses the form.
		/// </summary>
		void Close();
		#endregion

		#region Handle
		/// <summary>
		/// Gets the window handle of the form.
		/// </summary>
		IntPtr Handle
		{
			get;
		}
		#endregion

		#region Size
		System.Drawing.Size Size
		{
			get;
			set;
		}
		#endregion

		#region Location
		System.Drawing.Point Location
		{
			get;
			set;
		}
		#endregion
	}
}
