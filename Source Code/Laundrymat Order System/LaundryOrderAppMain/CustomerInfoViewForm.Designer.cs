namespace LaundryOrderAppMain
{
	partial class CustomerInfoViewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoViewForm));
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblCustomerId = new System.Windows.Forms.Label();
			this.lblCustomerComercial = new System.Windows.Forms.Label();
			this.rtxtPhoneEmailAddress = new System.Windows.Forms.RichTextBox();
			this.rtxtCustomerNotes = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerName.Location = new System.Drawing.Point(12, 9);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(61, 25);
			this.lblCustomerName.TabIndex = 0;
			this.lblCustomerName.Text = "name";
			// 
			// lblCustomerId
			// 
			this.lblCustomerId.AutoSize = true;
			this.lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerId.Location = new System.Drawing.Point(12, 43);
			this.lblCustomerId.Name = "lblCustomerId";
			this.lblCustomerId.Size = new System.Drawing.Size(91, 20);
			this.lblCustomerId.TabIndex = 1;
			this.lblCustomerId.Text = "Customer ID";
			// 
			// lblCustomerComercial
			// 
			this.lblCustomerComercial.AutoSize = true;
			this.lblCustomerComercial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerComercial.Location = new System.Drawing.Point(12, 65);
			this.lblCustomerComercial.Name = "lblCustomerComercial";
			this.lblCustomerComercial.Size = new System.Drawing.Size(86, 20);
			this.lblCustomerComercial.TabIndex = 2;
			this.lblCustomerComercial.Text = "IsComercial";
			// 
			// rtxtPhoneEmailAddress
			// 
			this.rtxtPhoneEmailAddress.BackColor = System.Drawing.Color.WhiteSmoke;
			this.rtxtPhoneEmailAddress.Location = new System.Drawing.Point(12, 99);
			this.rtxtPhoneEmailAddress.Name = "rtxtPhoneEmailAddress";
			this.rtxtPhoneEmailAddress.ReadOnly = true;
			this.rtxtPhoneEmailAddress.Size = new System.Drawing.Size(650, 54);
			this.rtxtPhoneEmailAddress.TabIndex = 3;
			this.rtxtPhoneEmailAddress.Text = "Phone#\nEmail\nAddress\n";
			// 
			// rtxtCustomerNotes
			// 
			this.rtxtCustomerNotes.Location = new System.Drawing.Point(12, 159);
			this.rtxtCustomerNotes.Name = "rtxtCustomerNotes";
			this.rtxtCustomerNotes.ReadOnly = true;
			this.rtxtCustomerNotes.Size = new System.Drawing.Size(650, 202);
			this.rtxtCustomerNotes.TabIndex = 4;
			this.rtxtCustomerNotes.Text = "CustomerNotes";
			// 
			// CustomerInfoViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 450);
			this.Controls.Add(this.rtxtCustomerNotes);
			this.Controls.Add(this.rtxtPhoneEmailAddress);
			this.Controls.Add(this.lblCustomerComercial);
			this.Controls.Add(this.lblCustomerId);
			this.Controls.Add(this.lblCustomerName);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomerInfoViewForm";
			this.Text = "Laundro Drop - Order Customer Info";
			this.Load += new System.EventHandler(this.CustomerInfoViewForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblCustomerName;
		private Label lblCustomerId;
		private Label lblCustomerComercial;
		private RichTextBox rtxtPhoneEmailAddress;
		private RichTextBox rtxtCustomerNotes;
	}
}