using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using ESolutions.AccessBridge.DotNet;
using ESolutions.AccessBridge.DotNet.Common;

namespace ESolutions.AccessBridge.Wrapper
{
	/// <summary>
	/// Delegate für das Leave-Form event
	/// </summary>
	/// <param name="formName">Name of the form.</param>
	/// <param name="returnValue">The return value.</param>
	public delegate void LeaveFormEventHandler(
		String formName,
		String returnValue);

	/// <summary>
	/// Handler for the LoadAnotherForm event.
	/// </summary>
	public delegate void LoadAnotherFormEventHandler(
		String assemblyName,
		String formTypeName);

	/// <summary>
	/// FormWrapper-Class is used as an interface between the dotnet and the MsAccess world.
	/// </summary>
	/// <seealso cref="ESolutions.AccessBridge.Wrapper.IFormWrapper" />
	[ComVisible(true)]
	[Guid("70C2E8ED-47FC-4374-B629-AA364CAAD1E9")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces("ESolutions.AccessBridge.Wrapper.IFormWrapperEvents")]
	public class FormWrapper : IFormWrapper
	{
		//Fields
		#region applicationSettings
		/// <summary>
		/// Settings for the application.
		/// </summary>
		private ApplicationSettings applicationSettings = null;
		#endregion

		#region loadedAssemblies
		/// <summary>
		/// A collection with all loaded assemblies. Needed to prevent assemblies from beeing loaded twice und deloading 
		/// assemblies properly.
		/// </summary>
		private static SortedList<string, Assembly> loadedAssemblies = new SortedList<string, Assembly>();
		#endregion

		#region loadedForms
		/// <summary>
		/// A collection with all loaded instances of forms. Needed to prevent forms from beeing loaded twice und deloading 
		/// forms properly.
		/// </summary>
		private static SortedList<string, IForm> loadedForms = new SortedList<string, IForm>();
		#endregion

		//Constructors
		#region FormWrapper
		/// <summary>
		/// Standard-Konstruktor
		/// </summary>
		public FormWrapper()
		{
		}
		#endregion

		//Events
		#region LeaveForm
		/// <summary>
		/// Occurs when a form is left.
		/// </summary>
		public event LeaveFormEventHandler LeaveForm;
		#endregion

		#region LoadAnotherForm
		/// <summary>
		/// Occurs when another form is requested
		/// </summary>
		public event LoadAnotherFormEventHandler LoadAnotherForm;
		#endregion

		//Methods
		#region Initialize
		/// <summary>
		/// Initializes the wrapper with the global settings from the access world.
		/// </summary>
		/// <param name="dataPath">Backend-Pfad</param>
		/// <param name="loggedUser">The logged user.</param>
		/// <param name="loggedUserName">Name des angemeldeten Users</param>
		/// <param name="dBHost">The d b host.</param>
		/// <param name="dBName">Name of the d b.</param>
		/// <param name="dBUser">The d b user.</param>
		/// <param name="dBPassword">The d b password.</param>
		[DispId(1)]
		public void Initialize(
			String dataPath,
			Int32 loggedUser,
			String loggedUserName,
			String dBHost,
			String dBName,
			String dBUser,
			String dBPassword)
		{
			try
			{
				this.applicationSettings = new ApplicationSettings(dataPath,
					 loggedUser,
					 loggedUserName,
					 dBHost,
					 dBName,
					 dBUser,
					 dBPassword);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region Load
		/// <summary>
		/// Lädt ein Form und gibt das entsprechende Windows-Handle zurück
		/// </summary>
		/// <param name="namespaceName">Name of the namespace.</param>
		/// <param name="formName">Name of the form.</param>
		/// <returns>
		/// Window-Handle des geladenen Forms
		/// </returns>
		[DispId(2)]
		public Int32 Load(
			String assemblyName,
			String formTypeName)
		{
			Int32 hwnd = 0;

			try
			{
				IForm form = this.GetFormObject(
					assemblyName,
					formTypeName);

				form.LeaveForm += this.LeaveFormHandler;
				form.LoadAnotherForm += this.LoadAnotherFormHandler;
				form.Initialize(this.applicationSettings);
				form.Show();

				hwnd = (Int32)form.Handle;
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return hwnd;
		}
		#endregion

		#region Unload
		/// <summary>
		/// Entlädt das angegebenen Form
		/// </summary>
		/// <param methodName="formName">Name des Forms, das entladen werden soll</param>
		[DispId(3)]
		public void Unload(
			String assemblyName,
			String formTypeName)
		{
			try
			{
				IForm form = this.GetFormObject(
					assemblyName,
					formTypeName);

				form.Close();

				loadedForms.Remove(form.GetType().FullName);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region SetAppearance
		/// <summary>
		/// Setzt die Position und Größe des Forms
		/// </summary>
		/// <param methodName="assemblyName">Name der Assembly</param>
		/// <param methodName="formName">Name des Forms</param>
		/// <param methodName="height">Höhe</param>
		/// <param methodName="width">Breite</param>
		/// <param methodName="top">x-Koordinate</param>
		/// <param methodName="left">y-Koordinate</param>        
		[DispId(4)]
		public void SetAppearance(
			String assemblyName,
			String formTypeName,
			Int32 height,
			Int32 width,
			Int32 top,
			Int32 left)
		{
			try
			{
				IForm form = this.GetFormObject(
					assemblyName,
					formTypeName);

				form.Size = new System.Drawing.Size(
					width,
					height);

				form.Location = new System.Drawing.Point(
					left,
					top);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region PutSettings
		/// <summary>
		/// Put settings into form.
		/// </summary>
		/// <param name="assemblyName">Name of the namespace.</param>
		/// <param name="formTypeName">Name of the form.</param>
		/// <param name="Parameter1">The parameter1.</param>
		/// <param name="Parameter2">The parameter2.</param>
		/// <param name="CanSave">if set to <c>true</c> [can save].</param>
		/// <param name="CanPrint">if set to <c>true</c> [can print].</param>
		[DispId(5)]
		public void PutSettings(
			String assemblyName,
			String formTypeName,
			String Parameter1,
			String Parameter2,
			ref Boolean CanSave,
			ref Boolean CanPrint)
		{
			try
			{
				IForm form = this.GetFormObject(
					assemblyName,
					formTypeName);

				form.PutSettings(
					Parameter1,
					Parameter2,
					ref CanSave,
					ref CanPrint);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region MasterIdChanged
		/// <summary>
		/// The master data selection in access changed. This assumes that there is a piece of data the form can not access but
		/// is needed to display to correct data in relation to the master data.
		/// </summary>
		/// <param methodName="assemblyName">Name der Assembly</param>
		/// <param methodName="formName">Name des Forms</param>
		/// <param methodName="PCode">Personencode</param>
		/// <param methodName="Vorname">Vorname der Person</param>
		/// <param methodName="Nachname">Nachname der Person</param>
		/// <param methodName="Icon">Icon</param>
		[DispId(6)]
		public void MasterIdChanged(
			String assemblyName,
			String formTypeName,
			Int32 MasterId)
		{
			try
			{
				IForm form = this.GetFormObject(
					assemblyName,
					formTypeName);

				MasterIdChangedEventArgs e = new MasterIdChangedEventArgs(MasterId);
				form.MasterIdChanged(e);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region LeaveFormHandler
		/// <summary>
		/// Event handler für das LeaveForm Event des entsprechenden Forms in der SCNet-Assemby
		/// </summary>
		/// <param methodName="sender"></param>
		/// <param methodName="e"></param>
		private void LeaveFormHandler(
			Object sender,
			LeaveFormEventArgs e)
		{
			try
			{
				this.LeaveForm(
					sender.ToString(),
					e.ReturnValue);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region LoadAnotherFormHandler
		private void LoadAnotherFormHandler(
			Object sender,
			LoadAnotherFormEventArgs e)
		{
			this.LoadAnotherForm(
				e.AssemblyName,
				e.FormTypeName);
		}
		#endregion

		#region GetFormObject
		/// <summary>
		/// Gets the form object.
		/// </summary>
		/// <param name="assemblyName">Name of the assembly.</param>
		/// <param name="formTypeName">Name of the form.</param>
		/// <returns></returns>
		private IForm GetFormObject(
			String assemblyName,
			String formTypeName)
		{
			IForm result = null;

			try
			{
				Assembly assembly = this.GetAssembly(assemblyName);

				if (loadedForms.ContainsKey(formTypeName))
				{
					result = loadedForms[formTypeName];
				}
				else
				{
					Module[] m = assembly.GetModules();

					Type myType = assembly.GetType(formTypeName, false, true);
					assembly.GetTypes();
					result = (IForm)Activator.CreateInstance(myType);
					loadedForms.Add(formTypeName, result);
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return result;
		}
		#endregion

		#region GetAssembly
		/// <summary>
		/// Gets the assembly.
		/// </summary>
		/// <param name="assemblyName">Name of the assembly.</param>
		/// <returns></returns>
		private Assembly GetAssembly(String assemblyName)
		{
			Assembly result = null;

			try
			{
				//Get Assembly
				String assemblyFullName = InstancesCollection.BuildAssemblyFullName(
					assemblyName,
					this.applicationSettings.DataPath);

				if (loadedAssemblies.ContainsKey(assemblyFullName) == false)
				{
					result = Assembly.LoadFrom(assemblyFullName);
					loadedAssemblies.Add(
						assemblyFullName,
						result);
				}
				else
				{
					result = loadedAssemblies[assemblyFullName];
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return result;
		}
		#endregion
	}
}