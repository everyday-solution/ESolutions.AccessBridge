using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESolutions.AccessBridge.DotNet
{
	public partial class ExceptionForm : Form
	{
		//Constructors
		#region ExceptionForm
		public ExceptionForm()
		{
			InitializeComponent();
		}
		#endregion

		//Methods
		#region Show
		/// <summary>
		/// Hides the inherited Show method.
		/// </summary>
		private new void Show()
		{
		}
		#endregion

		#region ShowDialog
		public static void ShowDialog(Exception ex)
		{
			var form = new ExceptionForm();
			form.messageLabel.Text = ex.Message;
			form.AddException(ex);
			form.exceptionListView.Items[0].Selected = true;
			form.ShowDialog();
		}
		#endregion

		#region AddException
		private void AddException(Exception ex)
		{
			var newListViewItem = new ListViewItem(ex.Message);
			newListViewItem.Tag = ex;
			this.exceptionListView.Items.Add(newListViewItem);

			if (ex.InnerException != null)
			{
				this.AddException(ex.InnerException);
			}
		}
		#endregion

		#region ContinueButton_Click
		private void ContinueButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region ExceptionListView_SelectedIndexChanged
		private void ExceptionListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.exceptionListView.SelectedItems.Count > 0)
			{
				Exception ex = this.exceptionListView.SelectedItems[0].Tag as Exception;
				this.messageLabel.Text = ex.Message;
				this.stackTraceLabel.Text = ex.StackTrace;
			}
		}
		#endregion
	}
}