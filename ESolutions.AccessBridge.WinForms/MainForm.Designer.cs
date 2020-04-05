namespace ESolutions.AccessBridge.WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "John",
            "Smith"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jack",
            "Miller"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Clark",
            "Kent"}, -1);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "William",
            "Gates"}, -1);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Conrad",
            "Muler"}, -1);
			this.formPanel = new System.Windows.Forms.Panel();
			this.mainSplitter = new System.Windows.Forms.SplitContainer();
			this.menuListBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MasterListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.formTitle = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).BeginInit();
			this.mainSplitter.Panel1.SuspendLayout();
			this.mainSplitter.Panel2.SuspendLayout();
			this.mainSplitter.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(14, 10);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(66, 25);
			label1.TabIndex = 1;
			label1.Text = "Menu";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(14, 10);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(78, 25);
			label2.TabIndex = 1;
			label2.Text = "Master";
			// 
			// formPanel
			// 
			this.formPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.formPanel.Location = new System.Drawing.Point(10, 69);
			this.formPanel.Name = "formPanel";
			this.formPanel.Size = new System.Drawing.Size(855, 770);
			this.formPanel.TabIndex = 0;
			// 
			// mainSplitter
			// 
			this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitter.Location = new System.Drawing.Point(0, 0);
			this.mainSplitter.Name = "mainSplitter";
			// 
			// mainSplitter.Panel1
			// 
			this.mainSplitter.Panel1.Controls.Add(this.menuListBox);
			this.mainSplitter.Panel1.Controls.Add(this.panel1);
			this.mainSplitter.Panel1.Controls.Add(this.MasterListView);
			this.mainSplitter.Panel1.Controls.Add(this.panel3);
			this.mainSplitter.Panel1.Padding = new System.Windows.Forms.Padding(10);
			// 
			// mainSplitter.Panel2
			// 
			this.mainSplitter.Panel2.Controls.Add(this.panel2);
			this.mainSplitter.Panel2.Controls.Add(this.formPanel);
			this.mainSplitter.Panel2.Padding = new System.Windows.Forms.Padding(10);
			this.mainSplitter.Size = new System.Drawing.Size(1322, 852);
			this.mainSplitter.SplitterDistance = 440;
			this.mainSplitter.TabIndex = 2;
			// 
			// menuListBox
			// 
			this.menuListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.menuListBox.FormattingEnabled = true;
			this.menuListBox.ItemHeight = 25;
			this.menuListBox.Location = new System.Drawing.Point(12, 61);
			this.menuListBox.Name = "menuListBox";
			this.menuListBox.Size = new System.Drawing.Size(415, 179);
			this.menuListBox.TabIndex = 6;
			this.menuListBox.DoubleClick += new System.EventHandler(this.MenuListBox_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(label2);
			this.panel1.Location = new System.Drawing.Point(12, 263);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(415, 44);
			this.panel1.TabIndex = 4;
			// 
			// MasterListView
			// 
			this.MasterListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MasterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.MasterListView.HideSelection = false;
			this.MasterListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
			this.MasterListView.Location = new System.Drawing.Point(14, 313);
			this.MasterListView.Name = "MasterListView";
			this.MasterListView.Size = new System.Drawing.Size(413, 527);
			this.MasterListView.TabIndex = 5;
			this.MasterListView.UseCompatibleStateImageBehavior = false;
			this.MasterListView.View = System.Windows.Forms.View.Details;
			this.MasterListView.SelectedIndexChanged += new System.EventHandler(this.MasterListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Forename";
			this.columnHeader1.Width = 133;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 180;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(label1);
			this.panel3.Location = new System.Drawing.Point(12, 10);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(415, 44);
			this.panel3.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.formTitle);
			this.panel2.Location = new System.Drawing.Point(10, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(856, 44);
			this.panel2.TabIndex = 2;
			// 
			// formTitle
			// 
			this.formTitle.AutoSize = true;
			this.formTitle.Location = new System.Drawing.Point(14, 10);
			this.formTitle.Name = "formTitle";
			this.formTitle.Size = new System.Drawing.Size(94, 25);
			this.formTitle.TabIndex = 1;
			this.formTitle.Text = "form title";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 852);
			this.Controls.Add(this.mainSplitter);
			this.Name = "MainForm";
			this.Text = "Access Bridge";
			this.mainSplitter.Panel1.ResumeLayout(false);
			this.mainSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).EndInit();
			this.mainSplitter.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel formPanel;
		private System.Windows.Forms.SplitContainer mainSplitter;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label formTitle;
		private System.Windows.Forms.ListView MasterListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox menuListBox;
	}
}

