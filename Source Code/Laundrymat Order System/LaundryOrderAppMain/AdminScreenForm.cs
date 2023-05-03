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
	public partial class AdminScreenForm : Form
	{
		LaundryOrderDbContext laundryDB;
		int CurrentPriceId;
		public AdminScreenForm(LaundryOrderDbContext db)
		{
			InitializeComponent();
			laundryDB = db;
		}

		private void AdminScreenForm_Load(object sender, EventArgs e)
		{
			dgvPricesView.DataSource = laundryDB.Prices.ToList();
			dgvPricesView.CurrentRow.Selected = false;
			lblSelectedItem.Text = $"No Item Selected";
			nupPriceInput.Enabled = false;
			btnUpdatePrice.Enabled = false;
		}

		private void dgvPricesView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvPricesView.CurrentRow.Selected = true;
			if (dgvPricesView.SelectedRows.Count == 0)
			{
				lblSelectedItem.Text = $"No Item Selected";
				nupPriceInput.Enabled = false;
				btnUpdatePrice.Enabled = false;
			}
			else
			{
				nupPriceInput.Enabled = true;
				btnUpdatePrice.Enabled = true;
				dgvPricesView.CurrentRow.Selected = true;
				CurrentPriceId = (int)dgvPricesView.SelectedRows[0].Cells[0].Value;
				nupPriceInput.Value = (decimal)laundryDB.Prices.Where(x => x.PricesID == (int)dgvPricesView.SelectedRows[0].Cells[0].Value).ToList()[0].Price;
				lblSelectedItem.Text = laundryDB.Prices.Where(x => x.PricesID == (int)dgvPricesView.SelectedRows[0].Cells[0].Value).ToList()[0].Name;
				
			}

		}

		private void btnUpdatePrice_Click(object sender, EventArgs e)
		{
			laundryDB.Prices.Where(x => x.PricesID == (int)dgvPricesView.SelectedRows[0].Cells[0].Value).ToList()[0].Price = (double)nupPriceInput.Value;
			laundryDB.SaveChanges();
			dgvPricesView.DataSource = laundryDB.Prices.ToList();
			dgvPricesView.CurrentRow.Selected = false;
			for (int i = 0; i < dgvPricesView.Rows.Count; i++)
			{
				if ((int)dgvPricesView.Rows[i].Cells[0].Value == CurrentPriceId)
				{
					dgvPricesView.Rows[i].Selected = true;
					break;
				}
			}
		}
	}
}
