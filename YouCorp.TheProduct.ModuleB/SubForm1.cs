using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESolutions.AccessBridge.DotNet;
using ESolutions.AccessBridge.DotNet.Common;

namespace YouCorp.TheProduct.ModuleB
{
	public partial class SubForm1 : Form, IForm
	{
		public SubForm1()
		{
			InitializeComponent();
		}

		public event LeaveFormHandler LeaveForm;
		public event LoadAnotherFormHandler LoadAnotherForm;

		public void Initialize(ApplicationSettings settings)
		{
		}

		public void MasterIdChanged(MasterIdChangedEventArgs e)
		{
			this.masterIdTextBox.Text = e.MasterId.ToString();
		}

		public void PutSettings(String Parameter1, String Parameter2, ref Boolean canSave, ref Boolean canPrint)
		{
		}
	}
}
