namespace ESolutions.AccessBridge.DotNet
{
	partial class ExceptionForm
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
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
			this.messageLabel = new System.Windows.Forms.Label();
			this.stackTraceLabel = new System.Windows.Forms.Label();
			this.continueButton = new System.Windows.Forms.Button();
			this.exceptionListView = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			flowLayoutPanel1.Controls.Add(this.messageLabel);
			flowLayoutPanel1.Location = new System.Drawing.Point(12, 37);
			flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new System.Drawing.Size(888, 79);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Location = new System.Drawing.Point(6, 0);
			this.messageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(70, 25);
			this.messageLabel.TabIndex = 0;
			this.messageLabel.Text = "label1";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox1.Controls.Add(flowLayoutPanel1);
			groupBox1.Location = new System.Drawing.Point(6, 6);
			groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			groupBox1.Size = new System.Drawing.Size(912, 127);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Message";
			// 
			// groupBox2
			// 
			groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox2.Controls.Add(flowLayoutPanel2);
			groupBox2.Location = new System.Drawing.Point(6, 145);
			groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			groupBox2.Size = new System.Drawing.Size(912, 726);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Stack Trace";
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			flowLayoutPanel2.Controls.Add(this.stackTraceLabel);
			flowLayoutPanel2.Location = new System.Drawing.Point(12, 37);
			flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new System.Drawing.Size(888, 677);
			flowLayoutPanel2.TabIndex = 2;
			// 
			// stackTraceLabel
			// 
			this.stackTraceLabel.AutoSize = true;
			this.stackTraceLabel.Location = new System.Drawing.Point(6, 0);
			this.stackTraceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.stackTraceLabel.Name = "stackTraceLabel";
			this.stackTraceLabel.Size = new System.Drawing.Size(70, 25);
			this.stackTraceLabel.TabIndex = 0;
			this.stackTraceLabel.Text = "label1";
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.continueButton.Location = new System.Drawing.Point(12, 898);
			this.continueButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(217, 44);
			this.continueButton.TabIndex = 1;
			this.continueButton.Text = "Weiter";
			this.continueButton.UseVisualStyleBackColor = true;
			this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
			// 
			// exceptionListView
			// 
			this.exceptionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.exceptionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
			this.exceptionListView.FullRowSelect = true;
			this.exceptionListView.HideSelection = false;
			this.exceptionListView.Location = new System.Drawing.Point(6, 6);
			this.exceptionListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.exceptionListView.MultiSelect = false;
			this.exceptionListView.Name = "exceptionListView";
			this.exceptionListView.Size = new System.Drawing.Size(455, 865);
			this.exceptionListView.TabIndex = 4;
			this.exceptionListView.UseCompatibleStateImageBehavior = false;
			this.exceptionListView.View = System.Windows.Forms.View.List;
			this.exceptionListView.SelectedIndexChanged += new System.EventHandler(this.ExceptionListView_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Text";
			this.columnHeader3.Width = 162;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.exceptionListView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(groupBox1);
			this.splitContainer1.Panel2.Controls.Add(groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(1401, 877);
			this.splitContainer1.SplitterDistance = 467;
			this.splitContainer1.TabIndex = 7;
			// 
			// ExceptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1437, 957);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.continueButton);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "ExceptionForm";
			this.Text = "ExceptionForm";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.ListView exceptionListView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label stackTraceLabel;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}