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
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			flowLayoutPanel1.Controls.Add(this.messageLabel);
			flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new System.Drawing.Size(381, 41);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Location = new System.Drawing.Point(3, 0);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(35, 13);
			this.messageLabel.TabIndex = 0;
			this.messageLabel.Text = "label1";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			groupBox1.Controls.Add(flowLayoutPanel1);
			groupBox1.Location = new System.Drawing.Point(185, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(393, 66);
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
			groupBox2.Location = new System.Drawing.Point(185, 84);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(393, 344);
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
			flowLayoutPanel2.Location = new System.Drawing.Point(6, 19);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new System.Drawing.Size(381, 319);
			flowLayoutPanel2.TabIndex = 2;
			// 
			// stackTraceLabel
			// 
			this.stackTraceLabel.AutoSize = true;
			this.stackTraceLabel.Location = new System.Drawing.Point(3, 0);
			this.stackTraceLabel.Name = "stackTraceLabel";
			this.stackTraceLabel.Size = new System.Drawing.Size(35, 13);
			this.stackTraceLabel.TabIndex = 0;
			this.stackTraceLabel.Text = "label1";
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.continueButton.Location = new System.Drawing.Point(200, 434);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(198, 23);
			this.continueButton.TabIndex = 1;
			this.continueButton.Text = "Weiter";
			this.continueButton.UseVisualStyleBackColor = true;
			this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
			// 
			// exceptionListView
			// 
			this.exceptionListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)));
			this.exceptionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
			this.exceptionListView.FullRowSelect = true;
			this.exceptionListView.Location = new System.Drawing.Point(12, 12);
			this.exceptionListView.MultiSelect = false;
			this.exceptionListView.Name = "exceptionListView";
			this.exceptionListView.Size = new System.Drawing.Size(167, 416);
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
			// ExceptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 469);
			this.Controls.Add(groupBox2);
			this.Controls.Add(groupBox1);
			this.Controls.Add(this.exceptionListView);
			this.Controls.Add(this.continueButton);
			this.Name = "ExceptionForm";
			this.Text = "ExceptionForm";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.ListView exceptionListView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label stackTraceLabel;

	}
}