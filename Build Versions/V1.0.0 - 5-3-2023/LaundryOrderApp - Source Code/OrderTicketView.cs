using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryOrderAppMain
{

	public partial class OrderTicketView : Form
	{
		Order currentOrder;
		PrintPreviewDialog prntprvw = new PrintPreviewDialog();
		PrintDocument prntdoc = new PrintDocument();
		Customer currentOrderCustomer;
		public OrderTicketView(Order importedOrder, Customer ImportedCustomer, string ticketType)
		{
			InitializeComponent();

			currentOrder = importedOrder;
			currentOrderCustomer = ImportedCustomer;

			lblTicketHeaderType.Text = $"{ticketType} Ticket";

			rtxtOrderInstructions.Text = $"{importedOrder.Instructions}";
			lblTotal.Text = $"Total: {importedOrder.TotalPrice.ToString("c2")}";
			lblCustId.Text = $"Customer ID: {importedOrder.CustomerID}";
			lblOrderId.Text = $"Order ID: {importedOrder.OrderID}";

			lsbItemsList.Items.Add($"Laundry Pounds: {importedOrder.LaundryPounds}");

			lsbItemsList.Items.Add($"-Comforters-");
			lsbItemsList.Items.Add($"Twin: {importedOrder.ComfortersTwin}");
			lsbItemsList.Items.Add($"Full: {importedOrder.ComfortersFull}");
			lsbItemsList.Items.Add($"Queen: {importedOrder.ComfortersQueen}");
			lsbItemsList.Items.Add($"King: {importedOrder.ComfortersKing}");

			lsbItemsList.Items.Add($"-Blankets-");
			lsbItemsList.Items.Add($"Twin: {importedOrder.BlanketsTwin}");
			lsbItemsList.Items.Add($"Full: {importedOrder.BlanketsFull}");
			lsbItemsList.Items.Add($"Queen: {importedOrder.BlanketsQueen}");
			lsbItemsList.Items.Add($"King: {importedOrder.BlanketsKing}");

			lsbItemsList.Items.Add($"-Rugs-");
			lsbItemsList.Items.Add($"Small: {importedOrder.RugsSmall}");
			lsbItemsList.Items.Add($"Large: {importedOrder.RugsLarge}");

			lsbItemsList.Items.Add($"-Sleeping Bags-");
			lsbItemsList.Items.Add($"Signle: {importedOrder.SleepingBagSingle}");
			lsbItemsList.Items.Add($"Double: {importedOrder.SleepingBagDouble}");

			lsbItemsList.Items.Add($"-Other-");
			lsbItemsList.Items.Add($"Pillows: {importedOrder.Pillows}");
			lsbItemsList.Items.Add($"Horse Blankets: {importedOrder.HorseBlankets}");


		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();

			PrintDocument printDocument = new PrintDocument();

			printDialog.Document = printDocument; //add the document to the dialog box...        

			printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

			//on a till you will not want to ask the user where to print but this is fine for the test envoironment.

			PrintPreviewDialog prntprvw = new PrintPreviewDialog();
			prntprvw.Document = printDocument;
			prntprvw.Show();

			DialogResult result = printDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				printDocument.Print();

			}
			this.Close();
		}

		public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			Graphics graphic = e.Graphics;

			Font font = new Font("Courier New", 12);

			float fontHeight = font.GetHeight();

			int startX = 10;
			int startY = 10;
			int offset = 40;

			graphic.DrawString("House Springs Coin Laundry", new Font("Times New Roman", 17, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontHeight + 7;
			if (lblTicketHeaderType.Text.Contains("Customer"))
			{
				graphic.DrawString($"Office Phone#: ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				graphic.DrawString("".PadLeft("Office Phone#: ".Count()) + $"(636) 375-3822", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"Office Hours:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"Mon-Fri 7am-11am | Sat-Sun: 9am-1pm", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"Self Service Hours:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"5am-11pm 365 Days a Year!", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
			}

			graphic.DrawString($"~{lblTicketHeaderType.Text}~", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontHeight + 5;

			if (!lblTicketHeaderType.Text.Contains("Customer"))
			{
				graphic.DrawString($"Customer:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				graphic.DrawString("".PadLeft("Customer:".Count()) + $" {currentOrderCustomer.Name}", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"Cust-Phone#:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				graphic.DrawString("".PadLeft("Cust-Phone#:".Count()) + $" {currentOrderCustomer.Phone}", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
				graphic.DrawString($"Comercial:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
				graphic.DrawString("".PadLeft("Comercial:".Count()) + $" {currentOrder.IsComercial}", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + (int)fontHeight;
			}



			graphic.DrawString($"Order Date: ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			graphic.DrawString("".PadLeft("Order Date: ".Count()) + $"{currentOrder.CreatedDate.Month}/{currentOrder.CreatedDate.Day}/{currentOrder.CreatedDate.Year}", font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontHeight;
			graphic.DrawString($"Customer ID: ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			graphic.DrawString("".PadLeft("Customer ID: ".Count()) + $"{currentOrderCustomer.CustomerID}", font, new SolidBrush(Color.Black), startX, startY + offset);
			graphic.DrawString("".PadLeft(("".PadLeft("Customer ID: ".Count()) + $"{currentOrderCustomer.CustomerID}").Count()) + $" | Order ID: ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			graphic.DrawString("".PadLeft(("".PadLeft(("".PadLeft("Customer ID: ".Count()) + $"{currentOrderCustomer.CustomerID}").Count()) + $"| Order ID: ").Count()) + $"{currentOrder.OrderID}", font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontHeight;
			graphic.DrawString("------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + (int)fontHeight + 5;


			foreach (string item in lsbItemsList.Items)
			{

				string productLine = item;

				graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

				offset = offset + (int)fontHeight + 5;

			}

			graphic.DrawString("------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);



			offset = offset + 30;
			graphic.DrawString("Total".PadRight(30) + String.Format("{0:c}", currentOrder.TotalPrice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
			offset = offset + 30;
			if (lblTicketHeaderType.Text.Contains("Customer"))
			{
				graphic.DrawString("     Thank-you for your order!,", font, new SolidBrush(Color.Black), startX, startY + offset);
				offset = offset + 15;
				graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
			}


		}


	}
}
