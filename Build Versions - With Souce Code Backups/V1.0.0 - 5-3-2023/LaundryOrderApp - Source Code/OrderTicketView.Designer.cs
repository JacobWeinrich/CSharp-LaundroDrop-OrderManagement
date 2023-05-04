namespace LaundryOrderAppMain
{
	partial class OrderTicketView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTicketView));
			this.panTicket = new System.Windows.Forms.Panel();
			this.lblOrderInstructions = new System.Windows.Forms.Label();
			this.rtxtOrderInstructions = new System.Windows.Forms.RichTextBox();
			this.lblCustId = new System.Windows.Forms.Label();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lsbItemsList = new System.Windows.Forms.ListBox();
			this.lblTicketHeaderType = new System.Windows.Forms.Label();
			this.lblTicketHeader1 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.printDoc1 = new System.Drawing.Printing.PrintDocument();
			this.panTicket.SuspendLayout();
			this.SuspendLayout();
			// 
			// panTicket
			// 
			this.panTicket.Controls.Add(this.lblOrderInstructions);
			this.panTicket.Controls.Add(this.rtxtOrderInstructions);
			this.panTicket.Controls.Add(this.lblCustId);
			this.panTicket.Controls.Add(this.lblOrderId);
			this.panTicket.Controls.Add(this.lblTotal);
			this.panTicket.Controls.Add(this.lsbItemsList);
			this.panTicket.Controls.Add(this.lblTicketHeaderType);
			this.panTicket.Controls.Add(this.lblTicketHeader1);
			this.panTicket.Location = new System.Drawing.Point(12, 12);
			this.panTicket.Name = "panTicket";
			this.panTicket.Size = new System.Drawing.Size(250, 632);
			this.panTicket.TabIndex = 0;
			// 
			// lblOrderInstructions
			// 
			this.lblOrderInstructions.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.lblOrderInstructions.Location = new System.Drawing.Point(0, 396);
			this.lblOrderInstructions.Name = "lblOrderInstructions";
			this.lblOrderInstructions.Size = new System.Drawing.Size(246, 18);
			this.lblOrderInstructions.TabIndex = 6;
			this.lblOrderInstructions.Text = "Instructions";
			this.lblOrderInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rtxtOrderInstructions
			// 
			this.rtxtOrderInstructions.Location = new System.Drawing.Point(0, 414);
			this.rtxtOrderInstructions.Name = "rtxtOrderInstructions";
			this.rtxtOrderInstructions.Size = new System.Drawing.Size(249, 122);
			this.rtxtOrderInstructions.TabIndex = 5;
			this.rtxtOrderInstructions.Text = "";
			// 
			// lblCustId
			// 
			this.lblCustId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustId.Location = new System.Drawing.Point(0, 539);
			this.lblCustId.Name = "lblCustId";
			this.lblCustId.Size = new System.Drawing.Size(250, 31);
			this.lblCustId.TabIndex = 4;
			this.lblCustId.Text = "Customer Id: 0";
			this.lblCustId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOrderId
			// 
			this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblOrderId.Location = new System.Drawing.Point(0, 570);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(250, 31);
			this.lblOrderId.TabIndex = 3;
			this.lblOrderId.Text = "Order Id: 0";
			this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTotal.Location = new System.Drawing.Point(0, 601);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(250, 31);
			this.lblTotal.TabIndex = 2;
			this.lblTotal.Text = "Total: $0.00";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lsbItemsList
			// 
			this.lsbItemsList.FormattingEnabled = true;
			this.lsbItemsList.ItemHeight = 15;
			this.lsbItemsList.Location = new System.Drawing.Point(0, 59);
			this.lsbItemsList.Name = "lsbItemsList";
			this.lsbItemsList.Size = new System.Drawing.Size(249, 334);
			this.lsbItemsList.TabIndex = 0;
			// 
			// lblTicketHeaderType
			// 
			this.lblTicketHeaderType.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTicketHeaderType.Location = new System.Drawing.Point(3, 28);
			this.lblTicketHeaderType.Name = "lblTicketHeaderType";
			this.lblTicketHeaderType.Size = new System.Drawing.Size(246, 28);
			this.lblTicketHeaderType.TabIndex = 1;
			this.lblTicketHeaderType.Text = "Basket Ticket";
			this.lblTicketHeaderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTicketHeader1
			// 
			this.lblTicketHeader1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.lblTicketHeader1.Location = new System.Drawing.Point(3, 0);
			this.lblTicketHeader1.Name = "lblTicketHeader1";
			this.lblTicketHeader1.Size = new System.Drawing.Size(246, 28);
			this.lblTicketHeader1.TabIndex = 0;
			this.lblTicketHeader1.Text = "House Springs Coin Laundry";
			this.lblTicketHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPrint.Location = new System.Drawing.Point(12, 666);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCancel.Location = new System.Drawing.Point(183, 666);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// OrderTicketView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 701);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.panTicket);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OrderTicketView";
			this.Text = "Laundro Drop - Ticket View";
			this.panTicket.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panTicket;
		private Label lblOrderInstructions;
		private RichTextBox rtxtOrderInstructions;
		private Label lblCustId;
		private Label lblOrderId;
		private Label lblTotal;
		private ListBox lsbItemsList;
		private Label lblTicketHeaderType;
		private Label lblTicketHeader1;
		private Button btnPrint;
		private Button btnCancel;
		private System.Drawing.Printing.PrintDocument printDoc1;
	}
}