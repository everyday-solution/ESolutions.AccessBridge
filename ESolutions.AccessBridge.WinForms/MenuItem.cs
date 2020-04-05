using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESolutions.AccessBridge.WinForms
{
public	class MenuItem
	{
		//Properties
		#region Key
		public String Key
		{
			get;
			set;
		}
		#endregion

		#region Text
		public String Text
		{
			get;
			set;
		}
		#endregion

		//Constructors
		#region MenuItem
		public MenuItem(String key, String text)
		{
			this.Key = key;
			this.Text = text;
		}
		#endregion

		//Methods
		#region ToString
		public override String ToString()
		{
			return this.Text;
		}
		#endregion
	}
}
