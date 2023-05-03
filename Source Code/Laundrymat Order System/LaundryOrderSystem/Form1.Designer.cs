namespace LaundryOrderSystem
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panMain = new System.Windows.Forms.Panel();
			this.tconPages = new System.Windows.Forms.TabControl();
			this.tapPageCustomers = new System.Windows.Forms.TabPage();
			this.tapPageOrderCreate = new System.Windows.Forms.TabPage();
			this.tapPageMain = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panTopBar = new System.Windows.Forms.Panel();
			this.btnTopBarMinWindow = new System.Windows.Forms.Button();
			this.btnTopBarMaxWindow = new System.Windows.Forms.Button();
			this.btnTopBarWindowClose = new System.Windows.Forms.Button();
			this.lblTopBarTittle = new System.Windows.Forms.Label();
			this.panMain.SuspendLayout();
			this.tconPages.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panTopBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panMain
			// 
			this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panMain.AutoSize = true;
			this.panMain.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panMain.Controls.Add(this.tconPages);
			this.panMain.Controls.Add(this.panel2);
			this.panMain.Location = new System.Drawing.Point(0, 35);
			this.panMain.Name = "panMain";
			this.panMain.Size = new System.Drawing.Size(1242, 662);
			this.panMain.TabIndex = 0;
			// 
			// tconPages
			// 
			this.tconPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tconPages.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tconPages.Controls.Add(this.tapPageCustomers);
			this.tconPages.Controls.Add(this.tapPageOrderCreate);
			this.tconPages.Controls.Add(this.tapPageMain);
			this.tconPages.ItemSize = new System.Drawing.Size(0, 1);
			this.tconPages.Location = new System.Drawing.Point(224, 6);
			this.tconPages.Margin = new System.Windows.Forms.Padding(0);
			this.tconPages.Name = "tconPages";
			this.tconPages.Padding = new System.Drawing.Point(0, 0);
			this.tconPages.SelectedIndex = 0;
			this.tconPages.Size = new System.Drawing.Size(1011, 646);
			this.tconPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tconPages.TabIndex = 1;
			this.tconPages.TabStop = false;
			// 
			// tapPageCustomers
			// 
			this.tapPageCustomers.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tapPageCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tapPageCustomers.Location = new System.Drawing.Point(4, 5);
			this.tapPageCustomers.Margin = new System.Windows.Forms.Padding(0);
			this.tapPageCustomers.Name = "tapPageCustomers";
			this.tapPageCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tapPageCustomers.Size = new System.Drawing.Size(1003, 637);
			this.tapPageCustomers.TabIndex = 0;
			this.tapPageCustomers.Text = "tabPage1";
			// 
			// tapPageOrderCreate
			// 
			this.tapPageOrderCreate.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tapPageOrderCreate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tapPageOrderCreate.Location = new System.Drawing.Point(4, 5);
			this.tapPageOrderCreate.Name = "tapPageOrderCreate";
			this.tapPageOrderCreate.Padding = new System.Windows.Forms.Padding(3);
			this.tapPageOrderCreate.Size = new System.Drawing.Size(1003, 637);
			this.tapPageOrderCreate.TabIndex = 1;
			this.tapPageOrderCreate.Text = "tabPage2";
			// 
			// tapPageMain
			// 
			this.tapPageMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tapPageMain.Location = new System.Drawing.Point(4, 5);
			this.tapPageMain.Name = "tapPageMain";
			this.tapPageMain.Size = new System.Drawing.Size(1003, 637);
			this.tapPageMain.TabIndex = 2;
			this.tapPageMain.Text = "tabPage1";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.AutoSize = true;
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 645);
			this.panel2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(194, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panTopBar
			// 
			this.panTopBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.panTopBar.AllowDrop = true;
			this.panTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panTopBar.AutoSize = true;
			this.panTopBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panTopBar.BackColor = System.Drawing.Color.Navy;
			this.panTopBar.Controls.Add(this.btnTopBarMinWindow);
			this.panTopBar.Controls.Add(this.btnTopBarMaxWindow);
			this.panTopBar.Controls.Add(this.btnTopBarWindowClose);
			this.panTopBar.Controls.Add(this.lblTopBarTittle);
			this.panTopBar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panTopBar.Location = new System.Drawing.Point(0, 0);
			this.panTopBar.Name = "panTopBar";
			this.panTopBar.Size = new System.Drawing.Size(1245, 32);
			this.panTopBar.TabIndex = 1;
			this.panTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTopBar_MouseDown);
			this.panTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTopBar_MouseMove);
			this.panTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panTopBar_MouseUp);
			// 
			// btnTopBarMinWindow
			// 
			this.btnTopBarMinWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTopBarMinWindow.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnTopBarMinWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnTopBarMinWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTopBarMinWindow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTopBarMinWindow.Location = new System.Drawing.Point(1149, 6);
			this.btnTopBarMinWindow.Name = "btnTopBarMinWindow";
			this.btnTopBarMinWindow.Size = new System.Drawing.Size(27, 23);
			this.btnTopBarMinWindow.TabIndex = 2;
			this.btnTopBarMinWindow.Text = "v";
			this.btnTopBarMinWindow.UseVisualStyleBackColor = false;
			this.btnTopBarMinWindow.Click += new System.EventHandler(this.btnTopBarMinWindow_Click);
			// 
			// btnTopBarMaxWindow
			// 
			this.btnTopBarMaxWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTopBarMaxWindow.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnTopBarMaxWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnTopBarMaxWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTopBarMaxWindow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTopBarMaxWindow.Location = new System.Drawing.Point(1182, 6);
			this.btnTopBarMaxWindow.Name = "btnTopBarMaxWindow";
			this.btnTopBarMaxWindow.Size = new System.Drawing.Size(27, 23);
			this.btnTopBarMaxWindow.TabIndex = 1;
			this.btnTopBarMaxWindow.Text = "^";
			this.btnTopBarMaxWindow.UseVisualStyleBackColor = false;
			this.btnTopBarMaxWindow.Click += new System.EventHandler(this.btnTopBarMaxWindow_Click);
			// 
			// btnTopBarWindowClose
			// 
			this.btnTopBarWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTopBarWindowClose.BackColor = System.Drawing.Color.IndianRed;
			this.btnTopBarWindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnTopBarWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTopBarWindowClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTopBarWindowClose.Location = new System.Drawing.Point(1215, 6);
			this.btnTopBarWindowClose.Name = "btnTopBarWindowClose";
			this.btnTopBarWindowClose.Size = new System.Drawing.Size(27, 23);
			this.btnTopBarWindowClose.TabIndex = 0;
			this.btnTopBarWindowClose.Text = "X";
			this.btnTopBarWindowClose.UseVisualStyleBackColor = false;
			this.btnTopBarWindowClose.Click += new System.EventHandler(this.btnTopBarWindowClose_Click);
			// 
			// lblTopBarTittle
			// 
			this.lblTopBarTittle.AutoSize = true;
			this.lblTopBarTittle.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.lblTopBarTittle.ForeColor = System.Drawing.Color.White;
			this.lblTopBarTittle.Location = new System.Drawing.Point(12, 9);
			this.lblTopBarTittle.Name = "lblTopBarTittle";
			this.lblTopBarTittle.Size = new System.Drawing.Size(344, 18);
			this.lblTopBarTittle.TabIndex = 0;
			this.lblTopBarTittle.Text = "Laundromat Laundry Service Orders App";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1244, 692);
			this.Controls.Add(this.panTopBar);
			this.Controls.Add(this.panMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panMain.ResumeLayout(false);
			this.panMain.PerformLayout();
			this.tconPages.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panTopBar.ResumeLayout(false);
			this.panTopBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Panel panMain;
		private Panel panTopBar;
		private Button btnTopBarWindowClose;
		private Label lblTopBarTittle;
		private Button btnTopBarMinWindow;
		private Button btnTopBarMaxWindow;
		private Panel panel2;
		private Button button1;
		private TabControl tconPages;
		private TabPage tapPageCustomers;
		private TabPage tapPageOrderCreate;
		private TabPage tapPageMain;
	}
}