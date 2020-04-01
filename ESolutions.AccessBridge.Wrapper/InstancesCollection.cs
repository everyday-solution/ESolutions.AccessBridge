using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ESolutions.AccessBridge.Wrapper
{
	/// <summary>
	/// Collection keeping track of instances of IForm created through the FormWrapper.
	/// </summary>
	/// <seealso cref="System.Collections.Generic.Dictionary{System.Reflection.Assembly, System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String, System.Object}}}" />
	internal class InstancesCollection : Dictionary<Assembly, List<Dictionary<String, Object>>>
	{
		#region RemoveForm
		public void RemoveForm(String formName)
		{
			try
			{
				Dictionary<String, Object> formElement = this.GetFormElement(formName);

				if (formElement != null)
				{
					formElement.Remove(formName);
				}
				else
				{
					throw new Exception("Form " + formName + "not found");
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region GetFormElement
		public Dictionary<String, Object> GetFormElement(String formName)		
		{
			Dictionary<String, Object> returnValue = null;
			try
			{
				foreach (List<Dictionary<String, Object>> forms in this.Values)
				{
					foreach (Dictionary<String, Object> form in forms)
					{
						if (form.ContainsKey(formName))
						{
							returnValue = form;
						}
					}
				}				
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);				
			}
			return returnValue;
		}
		#endregion

		#region GetFormObject
		public Object GetFormObject(String formName)
		{
			Object returnValue = null;

			try
			{
				returnValue = this.GetFormElement(formName)[formName];
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);				
			}

			return returnValue;
		}
		#endregion

		#region FormLoaded
		public Boolean FormLoaded(String formName)
		{
			Boolean returnValue = false;

			try
			{
				if (this.GetFormElement(formName) != null)
				{
					returnValue = true;
				}				
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
			return returnValue;
		}
		#endregion

		#region AssemblyLoaded
		public Boolean AssemblyLoaded(String assemblyName)
		{
			Boolean returnValue = false;

			try
			{
				if (this.GetAssemblyByName(assemblyName) != null)
				{
					returnValue = true;
				}				
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);				
			}
			return returnValue;
		}
		#endregion

		#region AddForm
		public void AddForm(
			String assemblyName,
			String formName,
			Object form)
		{
			try
			{
				if (this.FormLoaded(formName) == false)
				{
					Assembly ass = this.GetAssemblyByName(assemblyName);

					if (ass != null)
					{
						Dictionary<String, Object> dict = new Dictionary<String, Object>();
						dict.Add(formName, form);
						this[ass].Add(dict);
					}
					else
					{
						throw new Exception("Assembly" + assemblyName + "not loaded");
					}
				}
				else
				{
					throw new Exception("Form " + formName + "already loaded");
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region GetAssemblyByName
		public Assembly GetAssemblyByName(String assemblyName)
		{
			Assembly returnValue = null;

			try
			{
				foreach (Assembly ass in this.Keys)
				{
					if (ass.ManifestModule.Name == assemblyName)
					{
						returnValue = ass;
					}
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return returnValue;
		}
		#endregion

		#region AddAssembly
		public void AddAssembly(Assembly ass)
		{
			try
			{
				if (this.GetAssemblyByName(ass.ManifestModule.Name) == null)
				{
					this.Add(ass, new List<Dictionary<string, object>>());
				}
				else
				{
					throw new Exception("Assembly" + ass.FullName + "already loaded");
				}
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}
		}
		#endregion

		#region BuildAssemblyFullName
		public static String BuildAssemblyFullName(
			String assemblyName,
			String dataPath)
		{
			String returnValue = String.Empty;
			String path = String.Empty;
			String fullpath = String.Empty;

			try
			{
				if (dataPath != null && dataPath != String.Empty)
				{
					path = dataPath + "\\dll\\";
					fullpath = String.Format(
						"{0}\\ESolutions.AccessBridge.Modules.{1}.dll",
						path,
						assemblyName);

					if (System.IO.File.Exists(fullpath))
					{
						returnValue = fullpath;
					}
					else
					{
						path = GetExecutingLocation(System.Reflection.Assembly.GetExecutingAssembly());
						returnValue = String.Format(
							"{0}\\ESolutions.AccessBridge.Modules.{1}.dll",
							path,
							assemblyName);
					}
				}
				else
				{
					path = GetExecutingLocation(System.Reflection.Assembly.GetExecutingAssembly());
					returnValue = String.Format(
						"{0}\\ESolutions.AccessBridge.Modules.{1}.dll",
						path,
						assemblyName);					
				}				
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return returnValue;
		}
		#endregion

		#region GetExecutingLocation
		private static String GetExecutingLocation(Assembly executingAssembly )
		{
			String location = String.Empty;

			try
			{
				location = System.IO.Path.GetDirectoryName(executingAssembly.Location);
			}
			catch (Exception ex)
			{
				ESolutions.AccessBridge.DotNet.Tracer.TraceException(ex);
			}

			return location;
		}
		#endregion
	}
}
