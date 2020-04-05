using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESolutions.AccessBridge.DotNet;
using ESolutions.AccessBridge.Wrapper;

namespace ESolutions.AccessBridge.WinForms
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		//Fields
		#region wrapper
		private FormWrapper wrapper = new FormWrapper();
		#endregion

		#region currentFormKey
		private String currentFormKey = null;
		#endregion

		#region menuItems
		private IEnumerable<MenuItem> menuItems = new List<MenuItem>() {
			new MenuItem("ModuleA.SubForm1", "Modul A1"),
			new MenuItem("ModuleB.SubForm1", "Modul B1")
		};
		#endregion

		//Constrcutor
		#region MainForm
		public MainForm()
		{
			this.InitializeComponent();

			this.wrapper.Initialize(
				"..\\..\\..\\out",
				1,
				"UserName",
				"dbHost",
				"dbName",
				"dbUser",
				"dbPass");

			this.menuListBox.Items.AddRange(this.menuItems.ToArray());
		}
		#endregion

		//Methods
		#region MenuListBox_DoubleClick
		private void MenuListBox_DoubleClick(Object sender, EventArgs e)
		{
			try
			{
				this.currentFormKey = (this.menuListBox.SelectedItem as MenuItem).Key;
				var subFormHandle = this.wrapper.Load((this.menuListBox.SelectedItem as MenuItem).Key);
				this.wrapper.SetAppearance(
					this.currentFormKey, 
					this.formPanel.Height, 
					this.formPanel.Width, 
					0,
					0);
				SetParent((IntPtr)subFormHandle, this.formPanel.Handle);
				this.formTitle.Text = (this.menuListBox.SelectedItem as MenuItem).Text;
			}
			catch (Exception ex)
			{
				ExceptionForm.ShowDialog(ex);
			}
		}
		#endregion

		#region MasterListView_SelectedIndexChanged
		private void MasterListView_SelectedIndexChanged(Object sender, EventArgs e)
		{
			try
			{
				if (this.wrapper != null && this.currentFormKey != null && this.MasterListView.SelectedItems.Count > 0)
				{
					this.wrapper.MasterIdChanged(this.currentFormKey, this.MasterListView.SelectedIndices[0]);
				}
			}
			catch (Exception ex)
			{
				ExceptionForm.ShowDialog(ex);
			}
		}
		#endregion
	}
}
