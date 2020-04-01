using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ESolutions.AccessBridge.Wrapper
{
	/// <summary>
	/// Events für den COM-Client des FormWrappers
	/// </summary>
	[ComVisible(true)]
	[GuidAttribute("D0285E2F-49FB-4011-935C-9ABF22A60F03")]
	[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
	public interface IFormWrapperEvents
	{
		/// <summary>
		/// Fires if a dot net form iniciates it closing.
		/// </summary>
		/// <param methodName="formName">Name des Forms, dass geschlossen wurde</param>
		/// <param methodName="returnValue">Optionaler Rückgabewert</param>
		void LeaveForm(
			String formName,
			String returnValue);

		/// <summary>
		/// Fires when dot net form requires a different form to open.
		/// </summary>
		/// <param name="menuEntryId">The menu entry identifier.</param>
		/// <param name="parameter">The parameter.</param>
		void LoadAnotherForm(
			Int32 menuEntryId,
			String parameter);
	}
}
