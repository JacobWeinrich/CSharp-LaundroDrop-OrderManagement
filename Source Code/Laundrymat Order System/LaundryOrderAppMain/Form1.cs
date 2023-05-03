using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace LaundryOrderAppMain
{
	public partial class Form1 : Form
	{
		//DataBase Varaibles
		LaundryOrderDbContext laundryOrderDB;
		List<Customer> customerList;
		Customer selectedCustomer;
		List<Order> OrdersList = new List<Order>();
		Order currentOrder;
		//Prices Vars
		List<Prices> prices;
		double totalPrice = 0;

		public Form1()
		{
			// Add Database
			laundryOrderDB = new LaundryOrderDbContext();
			prices = laundryOrderDB.Prices.Select(x => x).ToList();
			InitializeComponent();
			UpdateTotal();
		
				
			
		}
		//Global Events
		

		//True = Allows a button press to change tab control index / False keeps user from just changing page with tabs
		bool tabControlChanging = false;

		//Custmore Edit Mode Var
		bool isEditingCustomer = false;
		int selectingCustomerForPage = 0;

		//Button - HELP INFO
		private void btnScreenHelp_Click(object sender, EventArgs e)
		{
			if (tbcScreens.SelectedIndex == 0)
			{
				MessageBox.Show("This is the Instructions for Order Create Screen", "Create Order - HELP");
			}
			else if (tbcScreens.SelectedIndex == 1)
			{
				MessageBox.Show("This is the Instructions for Order Lookup Screen", "Create Lookup / Edit - HELP");
			}
		}

		//Tab Control - Stop Page Change unless a button/code changes it
		private void tbcScreens_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (tabControlChanging)
			{
				tabControlChanging = false;
			}
			else
			{
				e.Cancel = true;
			}
		}


		//Menu Buttons
		private void btnMenuCreateOrders_Click(object sender, EventArgs e)
		{
			tabControlChanging = true;
			tbcScreens.SelectedIndex = 0;
		}

		private void btnMenuOrderLookup_Click(object sender, EventArgs e)
		{
			tabControlChanging = true;
			tbcScreens.SelectedIndex = 2;
		}

		//Update on page change
		private void UpdateDisplays()
		{
			//Current Customer Display on order screen
			if (selectedCustomer != null)
			{
				List<Customer> currentCustomerList = new List<Customer>();
				currentCustomerList.Clear();
				currentCustomerList.Add(selectedCustomer);
				dgvCurrentCustomerDisplayOrderScreen.DataSource = currentCustomerList.Select(o => new { Cust_ID = o.CustomerID, Comercial = o.IsComercial, Name = o.Name, Phone = o.Phone, Email = o.Email, Address = o.Address }).ToList();

			}
			else
			{
				List<Customer> currentCustomerList = new List<Customer>();
				currentCustomerList.Clear();
				dgvCurrentCustomerDisplayOrderScreen.DataSource = currentCustomerList.Select(o => new { Cust_ID = o.CustomerID, Comercial = o.IsComercial, Name = o.Name, Phone = o.Phone, Email = o.Email, Address = o.Address }).ToList();

			}
		}
		private void tbcScreens_Selected(object sender, TabControlEventArgs e)
		{
			UpdateDisplays();
		}

		//Order Screen Controls
		private void btnCreateOrder_Click(object sender, EventArgs e)
		{

			if (selectedCustomer != null)
			{
				UpdateTotal();
				if (ValidateOrderFields())
				{
					try
					{
						Order newOrder = new Order
						{
							CustomerID = selectedCustomer.CustomerID,
							IsComercial = selectedCustomer.IsComercial,
							CreatedDate = DateTime.Now,
							TotalPrice = totalPrice,

							LaundryPounds = (double)nupLaundryPounds.Value,

							ComfortersTwin = (int)nupComforterTwin.Value,
							ComfortersFull = (int)nupComforterFull.Value,
							ComfortersQueen = (int)nupComforterQueen.Value,
							ComfortersKing = (int)nupComforterKing.Value,

							BlanketsTwin = (int)nupBlanketsTwin.Value,
							BlanketsFull = (int)nupBlanketsFull.Value,
							BlanketsQueen = (int)nupBlanketsQueen.Value,
							BlanketsKing = (int)nupBlanketsKing.Value,

							RugsSmall = (int)nupRugsSmall.Value,
							RugsLarge = (int)nupRugsLarge.Value,

							SleepingBagSingle = (int)nupSleepingBagsSmall.Value,
							SleepingBagDouble = (int)nupSleepingBagsLarge.Value,

							Pillows = (int)nupPillows.Value,
							HorseBlankets = (int)nupHorseBlanket.Value,

							Instructions = rtxtOrderInstructions.Text
						};

						laundryOrderDB.Orders.Add(newOrder);
						laundryOrderDB.SaveChanges();

						OrdersList.Clear();
						OrdersList.Add(laundryOrderDB.Orders.OrderBy(x => x.OrderID).Last());
						currentOrder = OrdersList[0];
						dgvOrderSelectList.DataSource = OrdersList.Select(x => new { Order_ID = x.OrderID, Cust_ID = x.CustomerID, Created_Date = x.CreatedDate, Total = x.TotalPrice, Paid = x.IsPaid, PickedUp = x.IsPickedUp, PickedUp_Date = x.PickUpDate }).ToList(); ;
						tabControlChanging = true;
						tbcScreens.SelectedIndex = 2;
						ClearOrderFields();
					}
					catch (Exception)
					{
						MessageBox.Show("Error on Creation of order please Contact Admin", "ERROR: Couldnt Create Order!", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}
				else
				{
					MessageBox.Show("At Least 1 Field must have a value greator than 1\nNO Items Added Please Add a item to Create Order", "WARNING: No Items on order!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("No Customer Selected.\nPlease Select a Customer Account.", "WARNING: No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}







		}
		private void UnlockOrderFields()
		{
			foreach (NumericUpDown item in tbpOrderCreateScreen.Controls.OfType<NumericUpDown>())
			{
				item.Value = 0;
			}
			foreach (var item in tbpOrderCreateScreen.Controls.OfType<GroupBox>())
			{
				foreach (var item2 in item.Controls.OfType<NumericUpDown>())
				{
					item2.Value = 0;
				}
			}
			rtxtOrderInstructions.Enabled = false;
		}
		private bool ValidateOrderFields()
		{
			bool hasValue = false;
			foreach (NumericUpDown item in tbpOrderCreateScreen.Controls.OfType<NumericUpDown>())
			{
				if (item.Value >= 1)
				{
					hasValue = true;
				}
			}
			foreach (var item in tbpOrderCreateScreen.Controls.OfType<GroupBox>())
			{
				foreach (var item2 in item.Controls.OfType<NumericUpDown>())
				{
					if (item2.Value >= 1)
					{
						hasValue = true;
					}
				}
			}
			return hasValue;
		}
		private void ClearOrderFields()
		{
			selectedCustomer = null;
			rtxtOrderInstructions.Text = string.Empty;
			UpdateDisplays();
			foreach (NumericUpDown item in tbpOrderCreateScreen.Controls.OfType<NumericUpDown>())
			{
				item.Value = 0;
			}
			foreach (var item in tbpOrderCreateScreen.Controls.OfType<GroupBox>())
			{
				foreach (var item2 in item.Controls.OfType<NumericUpDown>())
				{
					item2.Value = 0;
				}
			}
		}

		private void nupOrderValues_ValueChanged(object sender, EventArgs e)
		{

			UpdateTotal();
		}

		private void UpdateTotal()
		{
			totalPrice = 0;
			if (selectedCustomer != null)
			{
				if (selectedCustomer.IsComercial)
				{
					totalPrice += prices.Find(x => x.Name == "PricePerPound-Comercial").Price * (double)nupLaundryPounds.Value;
				}
				else
				{
					totalPrice += prices.Find(x => x.Name == "PricePerPound").Price * (double)nupLaundryPounds.Value;
				}
				totalPrice +=
					prices.Find(x => x.Name == "Comforter-Twin").Price * (int)nupComforterTwin.Value +
					prices.Find(x => x.Name == "Comforter-Full").Price * (int)nupComforterFull.Value +
					prices.Find(x => x.Name == "Comforter-Queen").Price * (int)nupComforterQueen.Value +
					prices.Find(x => x.Name == "Comforter-King").Price * (int)nupComforterKing.Value +

					prices.Find(x => x.Name == "Blanket-Twin").Price * (int)nupBlanketsTwin.Value +
					prices.Find(x => x.Name == "Blanket-Full").Price * (int)nupBlanketsFull.Value +
					prices.Find(x => x.Name == "Blanket-Queen").Price * (int)nupBlanketsQueen.Value +
					prices.Find(x => x.Name == "Blanket-King").Price * (int)nupBlanketsKing.Value +

					prices.Find(x => x.Name == "Rug-Small").Price * (int)nupRugsSmall.Value +
					prices.Find(x => x.Name == "Rug-Large").Price * (int)nupRugsLarge.Value +

					prices.Find(x => x.Name == "SleepingBag-Single").Price * (int)nupSleepingBagsSmall.Value +
					prices.Find(x => x.Name == "SleepingBag-Large").Price * (int)nupSleepingBagsLarge.Value +

					prices.Find(x => x.Name == "Pillow").Price * (int)nupPillows.Value +
					prices.Find(x => x.Name == "HorseBlanket").Price * (int)nupHorseBlanket.Value;
			}

			lblOrderScreenTotal.Text = $"Total: {totalPrice.ToString("c2")}";
		}
		private void btnCustomerSelectAdd_Click(object sender, EventArgs e)
		{
			tabControlChanging = true;
			tbcScreens.SelectedIndex = 1;
			selectingCustomerForPage = 0;
			SearchCustomer();
		}





		//Customer Select Screen
		private void btnSearchCustomer_Click(object sender, EventArgs e)
		{
			SearchCustomer();
		}
		private void SearchCustomer()
		{
			//Clear Selection and Edit Mode
			selectedCustomer = null;
			if (dgvCustomerSearchResults.Rows.Count != 0)
			{
				dgvCustomerSearchResults.CurrentRow.Selected = false;
			}


			btnCustomerAdd.Text = "Add Customer";
			isEditingCustomer = false;
			txtCustomerAddName.Text = "";
			txtCustomerAddPhone.Text = "";
			txtCustomerAddEmail.Text = "";
			txtCustomerAddAddress.Text = "";
			chbIsComercial.Checked = false;
			rtxtCustomerAddInstructions.Text = "";

			txtCustomerAddName.Enabled = true;

			//Search Database
			int searchCustID;
			if (int.TryParse(txtCustomerSearchInput.Text, out searchCustID))
			{
				customerList = laundryOrderDB.Customers.Where(x => x.CustomerID == searchCustID && x.IsEnabled == true).ToList();
			}
			else
			{
				customerList = laundryOrderDB.Customers.Where(x => (x.Name.Contains(txtCustomerSearchInput.Text) || x.Phone == txtCustomerSearchInput.Text || x.Email.Contains(txtCustomerSearchInput.Text)) && x.IsEnabled == true).ToList();
			}
			if (customerList.Count == 0)
			{
				lblCustomerSearchResultErrors.Visible = true;
				customerList.Clear();
				dgvCustomerSearchResults.DataSource = customerList.Select(o => new { Cust_ID = o.CustomerID, Comercial = o.IsComercial, Name = o.Name, Phone = o.Phone, Email = o.Email, Address = o.Address }).ToList();

			}
			else
			{
				lblCustomerSearchResultErrors.Visible = false;
				dgvCustomerSearchResults.DataSource = customerList.Select(o => new { Cust_ID = o.CustomerID, Comercial = o.IsComercial, Name = o.Name, Phone = o.Phone, Email = o.Email, Address = o.Address }).ToList();
				if (dgvCustomerSearchResults.CurrentCell != null)
				{
					dgvCustomerSearchResults.CurrentCell.Selected = false;
				}
			}
		}
		private void btnConfirmCustomerSelection_Click(object sender, EventArgs e) //Confirm selction of customer button
		{
			if (dgvCustomerSearchResults.SelectedRows.Count != 0)
			{
				selectedCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == (int)dgvCustomerSearchResults.SelectedRows[0].Cells[0].Value).ToList()[0];
				tabControlChanging = true;
				tbcScreens.SelectedIndex = selectingCustomerForPage;

				if (selectingCustomerForPage == 2)
				{
					txtCustomerID.Text = $"{selectedCustomer.CustomerID}";
					SearchCustomerOrders();
				}

				rtxtOrderInstructions.Text = $"Customer Account Instructions: {selectedCustomer.Instructions}";

			}

		}

		private void dgvCustomerSearchResults_CellClick(object sender, DataGridViewCellEventArgs e) //Select entire row of customer when user clicks it
		{
			dgvCustomerSearchResults.CurrentRow.Selected = true;
			selectedCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == (int)dgvCustomerSearchResults.SelectedRows[0].Cells[0].Value).ToList()[0];

			btnCustomerAdd.Text = "EDIT Customer";
			isEditingCustomer = true;
			txtCustomerAddName.Text = selectedCustomer.Name;
			txtCustomerAddPhone.Text = selectedCustomer.Phone;
			txtCustomerAddEmail.Text = selectedCustomer.Email;
			txtCustomerAddAddress.Text = selectedCustomer.Address;
			chbIsComercial.Checked = selectedCustomer.IsComercial;
			rtxtCustomerAddInstructions.Text = selectedCustomer.Instructions;

			txtCustomerAddName.Enabled = false;

		}

		private void btnCustomerAdd_Click(object sender, EventArgs e) //add new customer BTN
		{

			if ((txtCustomerAddName.Text == string.Empty || txtCustomerAddPhone.Text == string.Empty))
			{
				MessageBox.Show("Customer Name AND Phone# are REQUIRED", "ERROR: Missing Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
			{
				if (isEditingCustomer)
				{
					try
					{
						selectedCustomer.Name = txtCustomerAddName.Text;
						laundryOrderDB.Customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList()[0].Phone = txtCustomerAddPhone.Text;
						laundryOrderDB.Customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList()[0].Email = txtCustomerAddEmail.Text;
						laundryOrderDB.Customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList()[0].Address = txtCustomerAddAddress.Text;
						laundryOrderDB.Customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList()[0].IsComercial = chbIsComercial.Checked;
						laundryOrderDB.Customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList()[0].Instructions = rtxtCustomerAddInstructions.Text;
						laundryOrderDB.SaveChanges();

						SearchCustomer();
						dgvCustomerSearchResults.Refresh();

						dgvCustomerSearchResults.Rows[customerList.FindIndex(x => x.CustomerID == selectedCustomer.CustomerID)].Cells[0].Selected = true;
						dgvCustomerSearchResults.CurrentRow.Selected = true;


					}
					catch (Exception)
					{

					}
				}
				else
				{
					if (laundryOrderDB.Customers.Where(x => x.Phone == txtCustomerAddPhone.Text || (x.Email == txtCustomerAddEmail.Text && txtCustomerAddEmail.Text != string.Empty)).Count() != 0)
					{
						MessageBox.Show("Duplicated Customer Detected.\nAnother Account has same EMAIL or PHONE#.\nUse the already created Account", "ERROR: Missing Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						Customer newCustomer = new Customer { Name = txtCustomerAddName.Text, IsComercial = chbIsComercial.Checked, Phone = txtCustomerAddPhone.Text, Email = txtCustomerAddEmail.Text, Address = txtCustomerAddAddress.Text, Instructions = rtxtCustomerAddInstructions.Text };
						try
						{


							laundryOrderDB.Customers.Add(newCustomer);
							laundryOrderDB.SaveChanges();

						}
						catch (Exception)
						{


						}
						List<Customer> currentCustomerList = new List<Customer>();
						currentCustomerList.Add(laundryOrderDB.Customers.ToList()[laundryOrderDB.Customers.Count() - 1]);
						dgvCustomerSearchResults.DataSource = currentCustomerList.Select(o => new { Cust_ID = o.CustomerID, Comercial = o.IsComercial, Name = o.Name, Phone = o.Phone, Email = o.Email, Address = o.Address }).ToList();
						dgvCustomerSearchResults.CurrentRow.Selected = true;

						selectedCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == (int)dgvCustomerSearchResults.SelectedRows[0].Cells[0].Value).ToList()[0];

						btnCustomerAdd.Text = "EDIT Customer";
						isEditingCustomer = true;
						txtCustomerAddName.Text = selectedCustomer.Name;
						txtCustomerAddPhone.Text = selectedCustomer.Phone;
						txtCustomerAddEmail.Text = selectedCustomer.Email;
						txtCustomerAddAddress.Text = selectedCustomer.Address;
						chbIsComercial.Checked = selectedCustomer.IsComercial;
						rtxtCustomerAddInstructions.Text = selectedCustomer.Instructions;

						txtCustomerAddName.Enabled = false;
					}

				}

			}
			laundryOrderDB.SaveChanges();
		}

		private void btnEditCustomerCancel_Click(object sender, EventArgs e)
		{
			selectedCustomer = null;
			if (dgvCustomerSearchResults.Rows.Count != 0)
			{
				dgvCustomerSearchResults.CurrentRow.Selected = false;
			}

			btnCustomerAdd.Text = "Add Customer";
			isEditingCustomer = false;
			txtCustomerAddName.Text = "";
			txtCustomerAddPhone.Text = "";
			txtCustomerAddEmail.Text = "";
			txtCustomerAddAddress.Text = "";
			chbIsComercial.Checked = false;
			rtxtCustomerAddInstructions.Text = "";

			txtCustomerAddName.Enabled = true;

		}
		//Order Lookup Screen

		private void btnSearchOrderNum_Click(object sender, EventArgs e)
		{
			int orderNumParsed;
			if (int.TryParse(txtOrderNumSearch.Text, out orderNumParsed))
			{
				OrdersList = laundryOrderDB.Orders.Where(o => o.OrderID == orderNumParsed).ToList();
				dgvOrderSelectList.DataSource = OrdersList.Select(x => new { Order_ID = x.OrderID, Cust_ID = x.CustomerID, Created_Date = x.CreatedDate, Total = x.TotalPrice, Paid = x.IsPaid, PickedUp = x.IsPickedUp, PickedUp_Date = x.PickUpDate }).ToList();
				if (OrdersList.Count != 0)
				{
					dgvOrderSelectList.Rows[0].Selected = true;
					currentOrder = OrdersList[OrdersList.FindIndex(x => x.OrderID == (int)dgvOrderSelectList.CurrentRow.Cells[0].Value)];
				}
			}
			else
			{
				MessageBox.Show("Invalid Order Number Input.\nMust Be only Numbers", "Order Number Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void btnMarkPaid_Click(object sender, EventArgs e)
		{
			if (currentOrder == null)
			{
				MessageBox.Show("Cant Update Paid Status.\nMust Select a Order First", "Order Update (Paid)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if (MessageBox.Show("Toggle Order Paid Status\nAre you sure.", "Warning Toggling Order Paid Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (currentOrder.IsPaid)
					{
						currentOrder.IsPaid = false;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].IsPaid = false;
					}
					else
					{
						currentOrder.IsPaid = true;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].IsPaid = true;
					}
					OrdersList = laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList();
					dgvOrderSelectList.DataSource = OrdersList.Select(x => new { Order_ID = x.OrderID, Cust_ID = x.CustomerID, Created_Date = x.CreatedDate, Total = x.TotalPrice, Paid = x.IsPaid, PickedUp = x.IsPickedUp, PickedUp_Date = x.PickUpDate }).ToList();
					dgvOrderSelectList.Rows[0].Selected = true;
				}
				else
				{

				}

			}
			laundryOrderDB.SaveChanges();


		}

		private void btnMarkPickup_Click(object sender, EventArgs e)
		{
			if (currentOrder == null)
			{
				MessageBox.Show("Cant Update PickedUp Status.\nMust Select a Order First", "Order Update (PickedUp)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				if (currentOrder.IsPickedUp)
				{
					if (MessageBox.Show("Mark Order NOT PICKED UP\nDoing So Will Remove The Pickup Date\nAre you sure.", "Warning Seting Order to NOT Picked Up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						currentOrder.IsPickedUp = false;
						currentOrder.PickUpDate = null;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].IsPickedUp = false;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].PickUpDate = null;

					}
					else
					{

					}


				}
				else
				{
					if (MessageBox.Show("Mark Order Picked Up\nAre you sure.", "Warning Marking Order as Picked Up", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						currentOrder.IsPickedUp = true;
						currentOrder.PickUpDate = DateTime.Now;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].IsPickedUp = true;
						laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList()[0].PickUpDate = DateTime.Now;
						
					}
				}
				OrdersList = laundryOrderDB.Orders.Where(x => x.OrderID == currentOrder.OrderID).ToList();
				dgvOrderSelectList.DataSource = OrdersList.Select(x => new { Order_ID = x.OrderID, Cust_ID = x.CustomerID, Created_Date = x.CreatedDate, Total = x.TotalPrice, Paid = x.IsPaid, PickedUp = x.IsPickedUp, PickedUp_Date = x.PickUpDate }).ToList();
				dgvOrderSelectList.Rows[0].Selected = true;
				laundryOrderDB.SaveChanges();

			}
		}
		private void btnViewOrderInstructions_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				MessageBox.Show(currentOrder.Instructions, "Selected Order Instructions", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Cant Display Order Instructions.\nMust Select Order First", "Order Instructions Display Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}
		private void dgvOrderSelectList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvOrderSelectList.CurrentRow.Selected = true;
			currentOrder = OrdersList[OrdersList.FindIndex(x => x.OrderID == (int)dgvOrderSelectList.CurrentRow.Cells[0].Value)];
		}

		private void btnLookupCustID_Click(object sender, EventArgs e)
		{

			tabControlChanging = true;
			tbcScreens.SelectedIndex = 1;
			selectingCustomerForPage = 2;


		}

		private void SearchCustomerOrders()
		{
			int parsedCustomerIdSearch;
			if (int.TryParse(txtCustomerID.Text, out parsedCustomerIdSearch))
			{
				OrdersList = laundryOrderDB.Orders.Where(x => x.CustomerID == parsedCustomerIdSearch).ToList();
				dgvOrderSelectList.DataSource = OrdersList.Select(x => new { Order_ID = x.OrderID, Cust_ID = x.CustomerID, Created_Date = x.CreatedDate, Total = x.TotalPrice, Paid = x.IsPaid, PickedUp = x.IsPickedUp, PickedUp_Date = x.PickUpDate }).ToList();
				for (int i = 0; i < dgvOrderSelectList.Rows.Count; i++)
				{
					dgvOrderSelectList.Rows[i].Selected = false;
				}
			}
			else
			{
				MessageBox.Show("Customer Id Input Must only contain NUMBERS", "Error: Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnSearchByCustomerID_Click(object sender, EventArgs e)
		{
			SearchCustomerOrders();
		}

		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				if (MessageBox.Show("Are you sure you want to delete this Order!\nThere is No Going Back", "WARNING: Delete Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{

					try
					{
						laundryOrderDB.Orders.Remove(currentOrder);
						laundryOrderDB.SaveChanges();

						OrdersList = null;
						dgvOrderSelectList.DataSource = OrdersList;
						currentOrder = null;
					}
					catch (Exception)
					{

					}


				}
			}
			else
			{
				MessageBox.Show("Cant Delete Order.\nMust Select Order First", "Order Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnPrintBasketTicket_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				Customer currentOrderCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == currentOrder.CustomerID).FirstOrDefault();
				new OrderTicketView(currentOrder, currentOrderCustomer, "Basket").Show();
			}
			else
			{
				MessageBox.Show("Cant Display Ticket For Order.\nMust Select Order First", "Order Ticket Display Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}


		private void btnPrintCustomerTicket_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				Customer currentOrderCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == currentOrder.CustomerID).FirstOrDefault();
				new OrderTicketView(currentOrder, currentOrderCustomer, "Customer").Show();
			}
			else
			{
				MessageBox.Show("Cant Display Ticket For Order.\nMust Select Order First", "Order Ticket Display Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnPrintEmployeeCopy_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				Customer currentOrderCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == currentOrder.CustomerID).FirstOrDefault();
				new OrderTicketView(currentOrder, currentOrderCustomer, "Employee").Show();
			}
			else
			{
				MessageBox.Show("Cant Display Ticket For Order.\nMust Select Order First", "Order Ticket Display Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnViewCustomerInfo_Click(object sender, EventArgs e)
		{
			if (currentOrder != null)
			{
				Customer currentOrderCustomer = laundryOrderDB.Customers.Where(x => x.CustomerID == currentOrder.CustomerID).FirstOrDefault();
				new CustomerInfoViewForm(currentOrderCustomer).Show();
			}
			else
			{
				MessageBox.Show("Cant Display Customer Info For Order.\nMust Select Order First", "Customer Info Display Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		//ADMIN COMMANDS
		private void btnAdminResetDbCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				laundryOrderDB.Customers.RemoveRange(laundryOrderDB.Customers.Where(x => x.CustomerID != 1));
				laundryOrderDB.SaveChanges();
				laundryOrderDB.Orders.RemoveRange(laundryOrderDB.Orders.Where(x => x.OrderID != 1));
				laundryOrderDB.SaveChanges();
			}
			catch (Exception)
			{

			}

		}

		private void btnAdminScreen_Click(object sender, EventArgs e)
		{

			

			if (Interaction.InputBox("To Access Admin Screen.\nEnter Admin Code:", "Admin Login", "", -1, -1) == "0022")
			{
				new AdminScreenForm(laundryOrderDB).Show();
			}
			
		}
	}
}