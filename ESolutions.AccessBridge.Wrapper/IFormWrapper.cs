using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ESolutions.AccessBridge.Wrapper
{
	/// <summary>
	/// Interface für die FormWrapper-Klasse. Hier werden die für den COM-Client bereitgestellten Funktionen definiert
	/// </summary>
	[ComVisible(true)]
	[Guid("FE1DA5A3-60ED-4123-98A9-F8EF3A0ADA4A")]
	public interface IFormWrapper
	{
		/// <summary>
		/// Loads a special implementation of an IForm
		/// </summary>
		/// <param name="assemblyName">Name of the assembly.</param>
		/// <param name="formName">Name of the form.</param>
		/// <returns></returns>
		Int32 Load(String multiKey);

		/// <summary>
		/// Unloads the specified form.
		/// </summary>
		/// <param name="assemblyName">Name of the assembly.</param>
		/// <param name="formName">Name of the form.</param>
		void Unload(String multiKey);

		/// <summary>
		/// Initializes the specified IForm with the global settings.
		/// </summary>
		/// <param name="dataPath">The data path.</param>
		/// <param name="loggedUser">The logged user.</param>
		/// <param name="loggedUserName">Name of the logged user.</param>
		/// <param name="dbName">Name of the database.</param>
		/// <param name="dBServer">The d b server.</param>
		/// <param name="dBUser">The d b user.</param>
		/// <param name="dbPassword">The database password.</param>
		void Initialize(
			String dataPath,
			Int32 loggedUser,
			String loggedUserName,
			String dbName,
			String dBServer,
			String dBUser,
			String dbPassword);

		/// <summary>
		/// Sets the appearance of the IForm
		/// </summary>
		/// <param name="multiKey">The multi key.</param>
		/// <param name="height">The height.</param>
		/// <param name="width">The width.</param>
		/// <param name="top">The top.</param>
		/// <param name="left">The left.</param>
		void SetAppearance(
			String multiKey,
			Int32 height,
			Int32 width,
			Int32 top,
			Int32 left);

		/// <summary>
		/// Puts the IForm specific settings
		/// </summary>
		/// <param name="multiKey">The multi key.</param>
		/// <param name="Parameter1">The parameter1.</param>
		/// <param name="Parameter2">The parameter2.</param>
		/// <param name="CanSave">if set to <c>true</c> [can save].</param>
		/// <param name="CanPrint">if set to <c>true</c> [can print].</param>
		void PutSettings(
			String multiKey,
			String Parameter1,
			String Parameter2,
			ref Boolean CanSave,
			ref Boolean CanPrint);

		/// <summary>
		/// The master id of parent data record in Access changed.
		/// </summary>
		/// <param name="multiKey">The multi key.</param>
		/// <param name="MasterId">The master identifier.</param>
		void MasterIdChanged(
			String multiKey,
			Int32 MasterId);
	}
}