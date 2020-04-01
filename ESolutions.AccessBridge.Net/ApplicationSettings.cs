using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet.Common
{
	public class ApplicationSettings
	{
		//Properties
		#region DataPath
		public String DataPath
		{
			get;
			private set;
		}
		#endregion

		#region LoggedUserId
		public int LoggedUserId
		{
			get;
			private set;
		}
		#endregion

		#region LoggedUserName
		public String LoggedUserName
		{
			get;
			private set;
		}
		#endregion

		#region DatabaseHost
		public String DatabaseHost
		{
			get;
			private set;
		}
		#endregion

		#region DatabaseName
		public String DatabaseName
		{
			get;
			set;
		}
		#endregion

		#region DatabaseUser
		public String DatabaseUser
		{
			get;
			set;
		}
		#endregion

		#region DatabasePassword
		public String DatabasePassword
		{
			get;
			private set;
		}
		#endregion

		//Constructors
		#region ApplicationInfo
		public ApplicationSettings(
				String dataPath,
				Int32 loggedUserId,
				String loggedUserName,
				String dbHost,
				String dbName,
				String dbUser,
				String dbPass)
		{
			this.DataPath = dataPath;
			this.LoggedUserId = loggedUserId;
			this.LoggedUserName = loggedUserName;
			this.DatabaseHost = dbHost;
			this.DatabaseName = dbName;
			this.DatabaseUser = dbUser;
			this.DatabasePassword = dbPass;
		}
		#endregion
	}
}
