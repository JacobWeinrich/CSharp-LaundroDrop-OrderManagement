using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryOrderAppMain
{
	public partial class CustomerInfoViewForm : Form
	{

		Customer importedCustomer;

		public CustomerInfoViewForm(Customer customer)
		{
			InitializeComponent();
			importedCustomer= customer;
		}

		private void CustomerInfoViewForm_Load(object sender, EventArgs e)
		{
			lblCustomerName.Text = importedCustomer.Name;
			lblCustomerId.Text = $"Customer ID: {importedCustomer.CustomerID}";
			lblCustomerComercial.Text = $"Comercial Customer: {importedCustomer.IsComercial}";
			rtxtPhoneEmailAddress.Text = $"Phone#: {importedCustomer.Phone}\nEmail: {importedCustomer.Email}\nAddress: {importedCustomer.Address}";
			rtxtCustomerNotes.Text = importedCustomer.Instructions;

		}
	}
}
