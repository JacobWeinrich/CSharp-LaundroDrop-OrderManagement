namespace LaundryOrderAppMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panMenusSideBar = new System.Windows.Forms.Panel();
			this.btnAdminScreen = new System.Windows.Forms.Button();
			this.btnAdminResetDbCustomer = new System.Windows.Forms.Button();
			this.btnScreenHelp = new System.Windows.Forms.Button();
			this.btnMenuOrderLookup = new System.Windows.Forms.Button();
			this.btnMenuCreateOrders = new System.Windows.Forms.Button();
			this.lblMenusTitle = new System.Windows.Forms.Label();
			this.tbcScreens = new System.Windows.Forms.TabControl();
			this.tbpOrderCreateScreen = new System.Windows.Forms.TabPage();
			this.lblOrderScreenTotal = new System.Windows.Forms.Label();
			this.dgvCurrentCustomerDisplayOrderScreen = new System.Windows.Forms.DataGridView();
			this.btnCreateOrder = new System.Windows.Forms.Button();
			this.lblOrderInstructions = new System.Windows.Forms.Label();
			this.rtxtOrderInstructions = new System.Windows.Forms.RichTextBox();
			this.grbOther = new System.Windows.Forms.GroupBox();
			this.lblHorseBlanket = new System.Windows.Forms.Label();
			this.lblPillows = new System.Windows.Forms.Label();
			this.nupHorseBlanket = new System.Windows.Forms.NumericUpDown();
			this.nupPillows = new System.Windows.Forms.NumericUpDown();
			this.grbSleepingBags = new System.Windows.Forms.GroupBox();
			this.lblSleepingBagsLarge = new System.Windows.Forms.Label();
			this.lblSleepingBagsSmall = new System.Windows.Forms.Label();
			this.nupSleepingBagsLarge = new System.Windows.Forms.NumericUpDown();
			this.nupSleepingBagsSmall = new System.Windows.Forms.NumericUpDown();
			this.grbRugs = new System.Windows.Forms.GroupBox();
			this.lblRugsLarge = new System.Windows.Forms.Label();
			this.lblRugsSmall = new System.Windows.Forms.Label();
			this.nupRugsLarge = new System.Windows.Forms.NumericUpDown();
			this.nupRugsSmall = new System.Windows.Forms.NumericUpDown();
			this.grbBlankets = new System.Windows.Forms.GroupBox();
			this.lblBlanketsKing = new System.Windows.Forms.Label();
			this.lblBlanketsQueen = new System.Windows.Forms.Label();
			this.lblBlanketsFull = new System.Windows.Forms.Label();
			this.lblBlanketsTwin = new System.Windows.Forms.Label();
			this.nupBlanketsKing = new System.Windows.Forms.NumericUpDown();
			this.nupBlanketsQueen = new System.Windows.Forms.NumericUpDown();
			this.nupBlanketsFull = new System.Windows.Forms.NumericUpDown();
			this.nupBlanketsTwin = new System.Windows.Forms.NumericUpDown();
			this.grbComforters = new System.Windows.Forms.GroupBox();
			this.lblComfortersKing = new System.Windows.Forms.Label();
			this.lblComfortersQueen = new System.Windows.Forms.Label();
			this.lblComfortersFull = new System.Windows.Forms.Label();
			this.lblComfortersTwin = new System.Windows.Forms.Label();
			this.nupComforterKing = new System.Windows.Forms.NumericUpDown();
			this.nupComforterQueen = new System.Windows.Forms.NumericUpDown();
			this.nupComforterFull = new System.Windows.Forms.NumericUpDown();
			this.nupComforterTwin = new System.Windows.Forms.NumericUpDown();
			this.lblLaundryPounds = new System.Windows.Forms.Label();
			this.nupLaundryPounds = new System.Windows.Forms.NumericUpDown();
			this.lblCurrentCustomer = new System.Windows.Forms.Label();
			this.lblStep1 = new System.Windows.Forms.Label();
			this.btnCustomerSelectAdd = new System.Windows.Forms.Button();
			this.tbpCustomerSelectScreen = new System.Windows.Forms.TabPage();
			this.grbCustomerAddFields = new System.Windows.Forms.GroupBox();
			this.btnEditCustomerCancel = new System.Windows.Forms.Button();
			this.chbIsComercial = new System.Windows.Forms.CheckBox();
			this.btnCustomerAdd = new System.Windows.Forms.Button();
			this.lblCustomerAddInstructions = new System.Windows.Forms.Label();
			this.rtxtCustomerAddInstructions = new System.Windows.Forms.RichTextBox();
			this.lblCustomerAddAddress = new System.Windows.Forms.Label();
			this.txtCustomerAddAddress = new System.Windows.Forms.TextBox();
			this.lblCustomerAddEmail = new System.Windows.Forms.Label();
			this.txtCustomerAddEmail = new System.Windows.Forms.TextBox();
			this.lblCustomerAddPhone = new System.Windows.Forms.Label();
			this.txtCustomerAddPhone = new System.Windows.Forms.TextBox();
			this.lblAddCustomerName = new System.Windows.Forms.Label();
			this.txtCustomerAddName = new System.Windows.Forms.TextBox();
			this.lblCustomerAddHint = new System.Windows.Forms.Label();
			this.lblCustomerSearchResultErrors = new System.Windows.Forms.Label();
			this.btnConfirmCustomerSelection = new System.Windows.Forms.Button();
			this.lblCustomerSearchResultsTitle = new System.Windows.Forms.Label();
			this.dgvCustomerSearchResults = new System.Windows.Forms.DataGridView();
			this.btnSearchCustomer = new System.Windows.Forms.Button();
			this.txtCustomerSearchInput = new System.Windows.Forms.TextBox();
			this.lblCustomerSelectInputTitle = new System.Windows.Forms.Label();
			this.tbpOrderEditScreen = new System.Windows.Forms.TabPage();
			this.lblDeleteWarning = new System.Windows.Forms.Label();
			this.lblViewOrderInfo = new System.Windows.Forms.Label();
			this.lblMarkStatus = new System.Windows.Forms.Label();
			this.lblPrintTickets = new System.Windows.Forms.Label();
			this.btnPrintEmployeeCopy = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.btnPrintCustomerTicket = new System.Windows.Forms.Button();
			this.btnPrintBasketTicket = new System.Windows.Forms.Button();
			this.btnMarkPaid = new System.Windows.Forms.Button();
			this.btnMarkPickup = new System.Windows.Forms.Button();
			this.btnViewCustomerInfo = new System.Windows.Forms.Button();
			this.btnViewOrderInstructions = new System.Windows.Forms.Button();
			this.lblSearchResults = new System.Windows.Forms.Label();
			this.btnSearchByCustomerID = new System.Windows.Forms.Button();
			this.dgvOrderSelectList = new System.Windows.Forms.DataGridView();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblCurrentCustomerID = new System.Windows.Forms.Label();
			this.btnLookupCustID = new System.Windows.Forms.Button();
			this.lblCustomerIdSearch = new System.Windows.Forms.Label();
			this.btnSearchOrderNum = new System.Windows.Forms.Button();
			this.lblOrderNumberInput = new System.Windows.Forms.Label();
			this.txtOrderNumSearch = new System.Windows.Forms.TextBox();
			this.lblOrderNumberSearch = new System.Windows.Forms.Label();
			this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbpCouponCheckScreen = new System.Windows.Forms.TabPage();
			this.txtCouponCodeScreenCodeInput = new System.Windows.Forms.TextBox();
			this.lblCouponCodeScreenCodeInput = new System.Windows.Forms.Label();
			this.btnCouponCodeScreenCheckCode = new System.Windows.Forms.Button();
			this.lblCouponCodeScreenResultTitleCouponCode = new System.Windows.Forms.Label();
			this.lblCouponCodeScreenResultTitleExpDate = new System.Windows.Forms.Label();
			this.panMenusSideBar.SuspendLayout();
			this.tbcScreens.SuspendLayout();
			this.tbpOrderCreateScreen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentCustomerDisplayOrderScreen)).BeginInit();
			this.grbOther.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupHorseBlanket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupPillows)).BeginInit();
			this.grbSleepingBags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupSleepingBagsLarge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupSleepingBagsSmall)).BeginInit();
			this.grbRugs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupRugsLarge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupRugsSmall)).BeginInit();
			this.grbBlankets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsKing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsQueen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsFull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsTwin)).BeginInit();
			this.grbComforters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterKing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterQueen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterFull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterTwin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupLaundryPounds)).BeginInit();
			this.tbpCustomerSelectScreen.SuspendLayout();
			this.grbCustomerAddFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSearchResults)).BeginInit();
			this.tbpOrderEditScreen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderSelectList)).BeginInit();
			this.tbpCouponCheckScreen.SuspendLayout();
			this.SuspendLayout();
			// 
			// panMenusSideBar
			// 
			this.panMenusSideBar.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panMenusSideBar.Controls.Add(this.btnAdminScreen);
			this.panMenusSideBar.Controls.Add(this.btnAdminResetDbCustomer);
			this.panMenusSideBar.Controls.Add(this.btnScreenHelp);
			this.panMenusSideBar.Controls.Add(this.btnMenuOrderLookup);
			this.panMenusSideBar.Controls.Add(this.btnMenuCreateOrders);
			this.panMenusSideBar.Controls.Add(this.lblMenusTitle);
			this.panMenusSideBar.Location = new System.Drawing.Point(12, 12);
			this.panMenusSideBar.Name = "panMenusSideBar";
			this.panMenusSideBar.Size = new System.Drawing.Size(175, 703);
			this.panMenusSideBar.TabIndex = 0;
			// 
			// btnAdminScreen
			// 
			this.btnAdminScreen.BackColor = System.Drawing.Color.Red;
			this.btnAdminScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdminScreen.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdminScreen.Location = new System.Drawing.Point(3, 572);
			this.btnAdminScreen.Name = "btnAdminScreen";
			this.btnAdminScreen.Size = new System.Drawing.Size(169, 45);
			this.btnAdminScreen.TabIndex = 5;
			this.btnAdminScreen.Text = "Admin Screen";
			this.btnAdminScreen.UseVisualStyleBackColor = false;
			this.btnAdminScreen.Click += new System.EventHandler(this.btnAdminScreen_Click);
			// 
			// btnAdminResetDbCustomer
			// 
			this.btnAdminResetDbCustomer.BackColor = System.Drawing.Color.Red;
			this.btnAdminResetDbCustomer.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdminResetDbCustomer.Location = new System.Drawing.Point(3, 623);
			this.btnAdminResetDbCustomer.Name = "btnAdminResetDbCustomer";
			this.btnAdminResetDbCustomer.Size = new System.Drawing.Size(172, 26);
			this.btnAdminResetDbCustomer.TabIndex = 4;
			this.btnAdminResetDbCustomer.Text = "Reset Order and Customer DB";
			this.btnAdminResetDbCustomer.UseVisualStyleBackColor = false;
			this.btnAdminResetDbCustomer.Visible = false;
			this.btnAdminResetDbCustomer.Click += new System.EventHandler(this.btnAdminResetDbCustomer_Click);
			// 
			// btnScreenHelp
			// 
			this.btnScreenHelp.BackColor = System.Drawing.Color.Yellow;
			this.btnScreenHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnScreenHelp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnScreenHelp.Location = new System.Drawing.Point(0, 655);
			this.btnScreenHelp.Name = "btnScreenHelp";
			this.btnScreenHelp.Size = new System.Drawing.Size(175, 48);
			this.btnScreenHelp.TabIndex = 3;
			this.btnScreenHelp.Text = "Press for HELP!";
			this.btnScreenHelp.UseVisualStyleBackColor = false;
			this.btnScreenHelp.Click += new System.EventHandler(this.btnScreenHelp_Click);
			// 
			// btnMenuOrderLookup
			// 
			this.btnMenuOrderLookup.Location = new System.Drawing.Point(0, 84);
			this.btnMenuOrderLookup.Name = "btnMenuOrderLookup";
			this.btnMenuOrderLookup.Size = new System.Drawing.Size(175, 38);
			this.btnMenuOrderLookup.TabIndex = 2;
			this.btnMenuOrderLookup.Text = "Order Lookup / Edit";
			this.btnMenuOrderLookup.UseVisualStyleBackColor = true;
			this.btnMenuOrderLookup.Click += new System.EventHandler(this.btnMenuOrderLookup_Click);
			// 
			// btnMenuCreateOrders
			// 
			this.btnMenuCreateOrders.Location = new System.Drawing.Point(0, 40);
			this.btnMenuCreateOrders.Name = "btnMenuCreateOrders";
			this.btnMenuCreateOrders.Size = new System.Drawing.Size(175, 38);
			this.btnMenuCreateOrders.TabIndex = 1;
			this.btnMenuCreateOrders.Text = "Create Orders";
			this.btnMenuCreateOrders.UseVisualStyleBackColor = true;
			this.btnMenuCreateOrders.Click += new System.EventHandler(this.btnMenuCreateOrders_Click);
			// 
			// lblMenusTitle
			// 
			this.lblMenusTitle.AutoSize = true;
			this.lblMenusTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMenusTitle.Location = new System.Drawing.Point(32, 0);
			this.lblMenusTitle.Name = "lblMenusTitle";
			this.lblMenusTitle.Size = new System.Drawing.Size(102, 37);
			this.lblMenusTitle.TabIndex = 0;
			this.lblMenusTitle.Text = "Menus";
			// 
			// tbcScreens
			// 
			this.tbcScreens.Controls.Add(this.tbpOrderCreateScreen);
			this.tbcScreens.Controls.Add(this.tbpCustomerSelectScreen);
			this.tbcScreens.Controls.Add(this.tbpOrderEditScreen);
			this.tbcScreens.Controls.Add(this.tbpCouponCheckScreen);
			this.tbcScreens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbcScreens.Location = new System.Drawing.Point(193, 12);
			this.tbcScreens.Name = "tbcScreens";
			this.tbcScreens.SelectedIndex = 0;
			this.tbcScreens.Size = new System.Drawing.Size(1082, 703);
			this.tbcScreens.TabIndex = 1;
			this.tbcScreens.TabStop = false;
			this.tbcScreens.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcScreens_Selecting);
			this.tbcScreens.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcScreens_Selected);
			// 
			// tbpOrderCreateScreen
			// 
			this.tbpOrderCreateScreen.BackColor = System.Drawing.Color.White;
			this.tbpOrderCreateScreen.Controls.Add(this.lblOrderScreenTotal);
			this.tbpOrderCreateScreen.Controls.Add(this.dgvCurrentCustomerDisplayOrderScreen);
			this.tbpOrderCreateScreen.Controls.Add(this.btnCreateOrder);
			this.tbpOrderCreateScreen.Controls.Add(this.lblOrderInstructions);
			this.tbpOrderCreateScreen.Controls.Add(this.rtxtOrderInstructions);
			this.tbpOrderCreateScreen.Controls.Add(this.grbOther);
			this.tbpOrderCreateScreen.Controls.Add(this.grbSleepingBags);
			this.tbpOrderCreateScreen.Controls.Add(this.grbRugs);
			this.tbpOrderCreateScreen.Controls.Add(this.grbBlankets);
			this.tbpOrderCreateScreen.Controls.Add(this.grbComforters);
			this.tbpOrderCreateScreen.Controls.Add(this.lblLaundryPounds);
			this.tbpOrderCreateScreen.Controls.Add(this.nupLaundryPounds);
			this.tbpOrderCreateScreen.Controls.Add(this.lblCurrentCustomer);
			this.tbpOrderCreateScreen.Controls.Add(this.lblStep1);
			this.tbpOrderCreateScreen.Controls.Add(this.btnCustomerSelectAdd);
			this.tbpOrderCreateScreen.Location = new System.Drawing.Point(4, 24);
			this.tbpOrderCreateScreen.Name = "tbpOrderCreateScreen";
			this.tbpOrderCreateScreen.Padding = new System.Windows.Forms.Padding(3);
			this.tbpOrderCreateScreen.Size = new System.Drawing.Size(1074, 675);
			this.tbpOrderCreateScreen.TabIndex = 0;
			this.tbpOrderCreateScreen.Text = "Order Create";
			// 
			// lblOrderScreenTotal
			// 
			this.lblOrderScreenTotal.AutoSize = true;
			this.lblOrderScreenTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblOrderScreenTotal.Location = new System.Drawing.Point(858, 605);
			this.lblOrderScreenTotal.Name = "lblOrderScreenTotal";
			this.lblOrderScreenTotal.Size = new System.Drawing.Size(61, 20);
			this.lblOrderScreenTotal.TabIndex = 19;
			this.lblOrderScreenTotal.Text = "Total: 0";
			// 
			// dgvCurrentCustomerDisplayOrderScreen
			// 
			this.dgvCurrentCustomerDisplayOrderScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCurrentCustomerDisplayOrderScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCurrentCustomerDisplayOrderScreen.Location = new System.Drawing.Point(305, 31);
			this.dgvCurrentCustomerDisplayOrderScreen.MultiSelect = false;
			this.dgvCurrentCustomerDisplayOrderScreen.Name = "dgvCurrentCustomerDisplayOrderScreen";
			this.dgvCurrentCustomerDisplayOrderScreen.ReadOnly = true;
			this.dgvCurrentCustomerDisplayOrderScreen.RowTemplate.Height = 25;
			this.dgvCurrentCustomerDisplayOrderScreen.Size = new System.Drawing.Size(763, 58);
			this.dgvCurrentCustomerDisplayOrderScreen.TabIndex = 18;
			// 
			// btnCreateOrder
			// 
			this.btnCreateOrder.BackColor = System.Drawing.Color.Lime;
			this.btnCreateOrder.FlatAppearance.BorderSize = 2;
			this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCreateOrder.Location = new System.Drawing.Point(858, 631);
			this.btnCreateOrder.Name = "btnCreateOrder";
			this.btnCreateOrder.Size = new System.Drawing.Size(210, 41);
			this.btnCreateOrder.TabIndex = 17;
			this.btnCreateOrder.Text = "Create Order";
			this.btnCreateOrder.UseVisualStyleBackColor = false;
			this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
			// 
			// lblOrderInstructions
			// 
			this.lblOrderInstructions.AutoSize = true;
			this.lblOrderInstructions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblOrderInstructions.Location = new System.Drawing.Point(6, 369);
			this.lblOrderInstructions.Name = "lblOrderInstructions";
			this.lblOrderInstructions.Size = new System.Drawing.Size(141, 20);
			this.lblOrderInstructions.TabIndex = 15;
			this.lblOrderInstructions.Text = "Order Instructions:";
			// 
			// rtxtOrderInstructions
			// 
			this.rtxtOrderInstructions.BackColor = System.Drawing.Color.Gainsboro;
			this.rtxtOrderInstructions.Location = new System.Drawing.Point(6, 392);
			this.rtxtOrderInstructions.Name = "rtxtOrderInstructions";
			this.rtxtOrderInstructions.Size = new System.Drawing.Size(647, 194);
			this.rtxtOrderInstructions.TabIndex = 14;
			this.rtxtOrderInstructions.Text = "";
			// 
			// grbOther
			// 
			this.grbOther.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grbOther.Controls.Add(this.lblHorseBlanket);
			this.grbOther.Controls.Add(this.lblPillows);
			this.grbOther.Controls.Add(this.nupHorseBlanket);
			this.grbOther.Controls.Add(this.nupPillows);
			this.grbOther.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grbOther.Location = new System.Drawing.Point(498, 286);
			this.grbOther.Name = "grbOther";
			this.grbOther.Size = new System.Drawing.Size(155, 80);
			this.grbOther.TabIndex = 13;
			this.grbOther.TabStop = false;
			this.grbOther.Text = "Other";
			// 
			// lblHorseBlanket
			// 
			this.lblHorseBlanket.AutoSize = true;
			this.lblHorseBlanket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblHorseBlanket.Location = new System.Drawing.Point(63, 53);
			this.lblHorseBlanket.Name = "lblHorseBlanket";
			this.lblHorseBlanket.Size = new System.Drawing.Size(86, 15);
			this.lblHorseBlanket.TabIndex = 5;
			this.lblHorseBlanket.Text = "Horse Blanket";
			// 
			// lblPillows
			// 
			this.lblPillows.AutoSize = true;
			this.lblPillows.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblPillows.Location = new System.Drawing.Point(63, 24);
			this.lblPillows.Name = "lblPillows";
			this.lblPillows.Size = new System.Drawing.Size(45, 15);
			this.lblPillows.TabIndex = 4;
			this.lblPillows.Text = "Pillows";
			// 
			// nupHorseBlanket
			// 
			this.nupHorseBlanket.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupHorseBlanket.Location = new System.Drawing.Point(6, 51);
			this.nupHorseBlanket.Name = "nupHorseBlanket";
			this.nupHorseBlanket.Size = new System.Drawing.Size(51, 24);
			this.nupHorseBlanket.TabIndex = 1;
			this.nupHorseBlanket.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupPillows
			// 
			this.nupPillows.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupPillows.Location = new System.Drawing.Point(6, 22);
			this.nupPillows.Name = "nupPillows";
			this.nupPillows.Size = new System.Drawing.Size(51, 24);
			this.nupPillows.TabIndex = 0;
			this.nupPillows.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// grbSleepingBags
			// 
			this.grbSleepingBags.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grbSleepingBags.Controls.Add(this.lblSleepingBagsLarge);
			this.grbSleepingBags.Controls.Add(this.lblSleepingBagsSmall);
			this.grbSleepingBags.Controls.Add(this.nupSleepingBagsLarge);
			this.grbSleepingBags.Controls.Add(this.nupSleepingBagsSmall);
			this.grbSleepingBags.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grbSleepingBags.Location = new System.Drawing.Point(375, 286);
			this.grbSleepingBags.Name = "grbSleepingBags";
			this.grbSleepingBags.Size = new System.Drawing.Size(117, 80);
			this.grbSleepingBags.TabIndex = 12;
			this.grbSleepingBags.TabStop = false;
			this.grbSleepingBags.Text = "Sleeping Bags";
			// 
			// lblSleepingBagsLarge
			// 
			this.lblSleepingBagsLarge.AutoSize = true;
			this.lblSleepingBagsLarge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSleepingBagsLarge.Location = new System.Drawing.Point(63, 53);
			this.lblSleepingBagsLarge.Name = "lblSleepingBagsLarge";
			this.lblSleepingBagsLarge.Size = new System.Drawing.Size(47, 15);
			this.lblSleepingBagsLarge.TabIndex = 5;
			this.lblSleepingBagsLarge.Text = "Double";
			// 
			// lblSleepingBagsSmall
			// 
			this.lblSleepingBagsSmall.AutoSize = true;
			this.lblSleepingBagsSmall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSleepingBagsSmall.Location = new System.Drawing.Point(63, 24);
			this.lblSleepingBagsSmall.Name = "lblSleepingBagsSmall";
			this.lblSleepingBagsSmall.Size = new System.Drawing.Size(41, 15);
			this.lblSleepingBagsSmall.TabIndex = 4;
			this.lblSleepingBagsSmall.Text = "Single";
			// 
			// nupSleepingBagsLarge
			// 
			this.nupSleepingBagsLarge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupSleepingBagsLarge.Location = new System.Drawing.Point(6, 51);
			this.nupSleepingBagsLarge.Name = "nupSleepingBagsLarge";
			this.nupSleepingBagsLarge.Size = new System.Drawing.Size(51, 24);
			this.nupSleepingBagsLarge.TabIndex = 1;
			this.nupSleepingBagsLarge.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupSleepingBagsSmall
			// 
			this.nupSleepingBagsSmall.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupSleepingBagsSmall.Location = new System.Drawing.Point(6, 22);
			this.nupSleepingBagsSmall.Name = "nupSleepingBagsSmall";
			this.nupSleepingBagsSmall.Size = new System.Drawing.Size(51, 24);
			this.nupSleepingBagsSmall.TabIndex = 0;
			this.nupSleepingBagsSmall.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// grbRugs
			// 
			this.grbRugs.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grbRugs.Controls.Add(this.lblRugsLarge);
			this.grbRugs.Controls.Add(this.lblRugsSmall);
			this.grbRugs.Controls.Add(this.nupRugsLarge);
			this.grbRugs.Controls.Add(this.nupRugsSmall);
			this.grbRugs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grbRugs.Location = new System.Drawing.Point(252, 286);
			this.grbRugs.Name = "grbRugs";
			this.grbRugs.Size = new System.Drawing.Size(117, 80);
			this.grbRugs.TabIndex = 11;
			this.grbRugs.TabStop = false;
			this.grbRugs.Text = "Rugs";
			// 
			// lblRugsLarge
			// 
			this.lblRugsLarge.AutoSize = true;
			this.lblRugsLarge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblRugsLarge.Location = new System.Drawing.Point(63, 53);
			this.lblRugsLarge.Name = "lblRugsLarge";
			this.lblRugsLarge.Size = new System.Drawing.Size(38, 15);
			this.lblRugsLarge.TabIndex = 5;
			this.lblRugsLarge.Text = "Large";
			// 
			// lblRugsSmall
			// 
			this.lblRugsSmall.AutoSize = true;
			this.lblRugsSmall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblRugsSmall.Location = new System.Drawing.Point(63, 24);
			this.lblRugsSmall.Name = "lblRugsSmall";
			this.lblRugsSmall.Size = new System.Drawing.Size(37, 15);
			this.lblRugsSmall.TabIndex = 4;
			this.lblRugsSmall.Text = "Small";
			// 
			// nupRugsLarge
			// 
			this.nupRugsLarge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupRugsLarge.Location = new System.Drawing.Point(6, 51);
			this.nupRugsLarge.Name = "nupRugsLarge";
			this.nupRugsLarge.Size = new System.Drawing.Size(51, 24);
			this.nupRugsLarge.TabIndex = 1;
			this.nupRugsLarge.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupRugsSmall
			// 
			this.nupRugsSmall.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupRugsSmall.Location = new System.Drawing.Point(6, 22);
			this.nupRugsSmall.Name = "nupRugsSmall";
			this.nupRugsSmall.Size = new System.Drawing.Size(51, 24);
			this.nupRugsSmall.TabIndex = 0;
			this.nupRugsSmall.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// grbBlankets
			// 
			this.grbBlankets.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grbBlankets.Controls.Add(this.lblBlanketsKing);
			this.grbBlankets.Controls.Add(this.lblBlanketsQueen);
			this.grbBlankets.Controls.Add(this.lblBlanketsFull);
			this.grbBlankets.Controls.Add(this.lblBlanketsTwin);
			this.grbBlankets.Controls.Add(this.nupBlanketsKing);
			this.grbBlankets.Controls.Add(this.nupBlanketsQueen);
			this.grbBlankets.Controls.Add(this.nupBlanketsFull);
			this.grbBlankets.Controls.Add(this.nupBlanketsTwin);
			this.grbBlankets.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grbBlankets.Location = new System.Drawing.Point(129, 225);
			this.grbBlankets.Name = "grbBlankets";
			this.grbBlankets.Size = new System.Drawing.Size(117, 141);
			this.grbBlankets.TabIndex = 10;
			this.grbBlankets.TabStop = false;
			this.grbBlankets.Text = "Blankets";
			// 
			// lblBlanketsKing
			// 
			this.lblBlanketsKing.AutoSize = true;
			this.lblBlanketsKing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBlanketsKing.Location = new System.Drawing.Point(63, 111);
			this.lblBlanketsKing.Name = "lblBlanketsKing";
			this.lblBlanketsKing.Size = new System.Drawing.Size(32, 15);
			this.lblBlanketsKing.TabIndex = 9;
			this.lblBlanketsKing.Text = "King";
			// 
			// lblBlanketsQueen
			// 
			this.lblBlanketsQueen.AutoSize = true;
			this.lblBlanketsQueen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBlanketsQueen.Location = new System.Drawing.Point(63, 82);
			this.lblBlanketsQueen.Name = "lblBlanketsQueen";
			this.lblBlanketsQueen.Size = new System.Drawing.Size(44, 15);
			this.lblBlanketsQueen.TabIndex = 6;
			this.lblBlanketsQueen.Text = "Queen";
			// 
			// lblBlanketsFull
			// 
			this.lblBlanketsFull.AutoSize = true;
			this.lblBlanketsFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBlanketsFull.Location = new System.Drawing.Point(63, 53);
			this.lblBlanketsFull.Name = "lblBlanketsFull";
			this.lblBlanketsFull.Size = new System.Drawing.Size(26, 15);
			this.lblBlanketsFull.TabIndex = 5;
			this.lblBlanketsFull.Text = "Full";
			// 
			// lblBlanketsTwin
			// 
			this.lblBlanketsTwin.AutoSize = true;
			this.lblBlanketsTwin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBlanketsTwin.Location = new System.Drawing.Point(63, 24);
			this.lblBlanketsTwin.Name = "lblBlanketsTwin";
			this.lblBlanketsTwin.Size = new System.Drawing.Size(33, 15);
			this.lblBlanketsTwin.TabIndex = 4;
			this.lblBlanketsTwin.Text = "Twin";
			// 
			// nupBlanketsKing
			// 
			this.nupBlanketsKing.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupBlanketsKing.Location = new System.Drawing.Point(6, 109);
			this.nupBlanketsKing.Name = "nupBlanketsKing";
			this.nupBlanketsKing.Size = new System.Drawing.Size(51, 24);
			this.nupBlanketsKing.TabIndex = 3;
			this.nupBlanketsKing.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupBlanketsQueen
			// 
			this.nupBlanketsQueen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupBlanketsQueen.Location = new System.Drawing.Point(6, 80);
			this.nupBlanketsQueen.Name = "nupBlanketsQueen";
			this.nupBlanketsQueen.Size = new System.Drawing.Size(51, 24);
			this.nupBlanketsQueen.TabIndex = 2;
			this.nupBlanketsQueen.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupBlanketsFull
			// 
			this.nupBlanketsFull.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupBlanketsFull.Location = new System.Drawing.Point(6, 51);
			this.nupBlanketsFull.Name = "nupBlanketsFull";
			this.nupBlanketsFull.Size = new System.Drawing.Size(51, 24);
			this.nupBlanketsFull.TabIndex = 1;
			this.nupBlanketsFull.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupBlanketsTwin
			// 
			this.nupBlanketsTwin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupBlanketsTwin.Location = new System.Drawing.Point(6, 22);
			this.nupBlanketsTwin.Name = "nupBlanketsTwin";
			this.nupBlanketsTwin.Size = new System.Drawing.Size(51, 24);
			this.nupBlanketsTwin.TabIndex = 0;
			this.nupBlanketsTwin.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// grbComforters
			// 
			this.grbComforters.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grbComforters.Controls.Add(this.lblComfortersKing);
			this.grbComforters.Controls.Add(this.lblComfortersQueen);
			this.grbComforters.Controls.Add(this.lblComfortersFull);
			this.grbComforters.Controls.Add(this.lblComfortersTwin);
			this.grbComforters.Controls.Add(this.nupComforterKing);
			this.grbComforters.Controls.Add(this.nupComforterQueen);
			this.grbComforters.Controls.Add(this.nupComforterFull);
			this.grbComforters.Controls.Add(this.nupComforterTwin);
			this.grbComforters.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grbComforters.Location = new System.Drawing.Point(6, 225);
			this.grbComforters.Name = "grbComforters";
			this.grbComforters.Size = new System.Drawing.Size(117, 141);
			this.grbComforters.TabIndex = 8;
			this.grbComforters.TabStop = false;
			this.grbComforters.Text = "Comforters";
			// 
			// lblComfortersKing
			// 
			this.lblComfortersKing.AutoSize = true;
			this.lblComfortersKing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblComfortersKing.Location = new System.Drawing.Point(63, 111);
			this.lblComfortersKing.Name = "lblComfortersKing";
			this.lblComfortersKing.Size = new System.Drawing.Size(32, 15);
			this.lblComfortersKing.TabIndex = 9;
			this.lblComfortersKing.Text = "King";
			// 
			// lblComfortersQueen
			// 
			this.lblComfortersQueen.AutoSize = true;
			this.lblComfortersQueen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblComfortersQueen.Location = new System.Drawing.Point(63, 82);
			this.lblComfortersQueen.Name = "lblComfortersQueen";
			this.lblComfortersQueen.Size = new System.Drawing.Size(44, 15);
			this.lblComfortersQueen.TabIndex = 6;
			this.lblComfortersQueen.Text = "Queen";
			// 
			// lblComfortersFull
			// 
			this.lblComfortersFull.AutoSize = true;
			this.lblComfortersFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblComfortersFull.Location = new System.Drawing.Point(63, 53);
			this.lblComfortersFull.Name = "lblComfortersFull";
			this.lblComfortersFull.Size = new System.Drawing.Size(26, 15);
			this.lblComfortersFull.TabIndex = 5;
			this.lblComfortersFull.Text = "Full";
			// 
			// lblComfortersTwin
			// 
			this.lblComfortersTwin.AutoSize = true;
			this.lblComfortersTwin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblComfortersTwin.Location = new System.Drawing.Point(63, 24);
			this.lblComfortersTwin.Name = "lblComfortersTwin";
			this.lblComfortersTwin.Size = new System.Drawing.Size(33, 15);
			this.lblComfortersTwin.TabIndex = 4;
			this.lblComfortersTwin.Text = "Twin";
			// 
			// nupComforterKing
			// 
			this.nupComforterKing.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupComforterKing.Location = new System.Drawing.Point(6, 109);
			this.nupComforterKing.Name = "nupComforterKing";
			this.nupComforterKing.Size = new System.Drawing.Size(51, 24);
			this.nupComforterKing.TabIndex = 3;
			this.nupComforterKing.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupComforterQueen
			// 
			this.nupComforterQueen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupComforterQueen.Location = new System.Drawing.Point(6, 80);
			this.nupComforterQueen.Name = "nupComforterQueen";
			this.nupComforterQueen.Size = new System.Drawing.Size(51, 24);
			this.nupComforterQueen.TabIndex = 2;
			this.nupComforterQueen.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupComforterFull
			// 
			this.nupComforterFull.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupComforterFull.Location = new System.Drawing.Point(6, 51);
			this.nupComforterFull.Name = "nupComforterFull";
			this.nupComforterFull.Size = new System.Drawing.Size(51, 24);
			this.nupComforterFull.TabIndex = 1;
			this.nupComforterFull.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// nupComforterTwin
			// 
			this.nupComforterTwin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nupComforterTwin.Location = new System.Drawing.Point(6, 22);
			this.nupComforterTwin.Name = "nupComforterTwin";
			this.nupComforterTwin.Size = new System.Drawing.Size(51, 24);
			this.nupComforterTwin.TabIndex = 0;
			this.nupComforterTwin.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// lblLaundryPounds
			// 
			this.lblLaundryPounds.AutoSize = true;
			this.lblLaundryPounds.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblLaundryPounds.Location = new System.Drawing.Point(6, 173);
			this.lblLaundryPounds.Name = "lblLaundryPounds";
			this.lblLaundryPounds.Size = new System.Drawing.Size(146, 20);
			this.lblLaundryPounds.TabIndex = 7;
			this.lblLaundryPounds.Text = "Pounds of Laundry:";
			// 
			// nupLaundryPounds
			// 
			this.nupLaundryPounds.DecimalPlaces = 2;
			this.nupLaundryPounds.Location = new System.Drawing.Point(6, 196);
			this.nupLaundryPounds.Name = "nupLaundryPounds";
			this.nupLaundryPounds.Size = new System.Drawing.Size(193, 23);
			this.nupLaundryPounds.TabIndex = 6;
			this.nupLaundryPounds.ValueChanged += new System.EventHandler(this.nupOrderValues_ValueChanged);
			// 
			// lblCurrentCustomer
			// 
			this.lblCurrentCustomer.AutoSize = true;
			this.lblCurrentCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCurrentCustomer.Location = new System.Drawing.Point(305, 8);
			this.lblCurrentCustomer.Name = "lblCurrentCustomer";
			this.lblCurrentCustomer.Size = new System.Drawing.Size(201, 20);
			this.lblCurrentCustomer.TabIndex = 3;
			this.lblCurrentCustomer.Text = "Current Selected Customer:";
			// 
			// lblStep1
			// 
			this.lblStep1.AutoSize = true;
			this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblStep1.Location = new System.Drawing.Point(6, 21);
			this.lblStep1.Name = "lblStep1";
			this.lblStep1.Size = new System.Drawing.Size(57, 20);
			this.lblStep1.TabIndex = 1;
			this.lblStep1.Text = "Step 1:";
			// 
			// btnCustomerSelectAdd
			// 
			this.btnCustomerSelectAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCustomerSelectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCustomerSelectAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCustomerSelectAdd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCustomerSelectAdd.Location = new System.Drawing.Point(69, 14);
			this.btnCustomerSelectAdd.Name = "btnCustomerSelectAdd";
			this.btnCustomerSelectAdd.Size = new System.Drawing.Size(230, 35);
			this.btnCustomerSelectAdd.TabIndex = 0;
			this.btnCustomerSelectAdd.Text = "Select / Add Customer";
			this.btnCustomerSelectAdd.UseVisualStyleBackColor = false;
			this.btnCustomerSelectAdd.Click += new System.EventHandler(this.btnCustomerSelectAdd_Click);
			// 
			// tbpCustomerSelectScreen
			// 
			this.tbpCustomerSelectScreen.BackColor = System.Drawing.Color.White;
			this.tbpCustomerSelectScreen.Controls.Add(this.grbCustomerAddFields);
			this.tbpCustomerSelectScreen.Controls.Add(this.lblCustomerSearchResultErrors);
			this.tbpCustomerSelectScreen.Controls.Add(this.btnConfirmCustomerSelection);
			this.tbpCustomerSelectScreen.Controls.Add(this.lblCustomerSearchResultsTitle);
			this.tbpCustomerSelectScreen.Controls.Add(this.dgvCustomerSearchResults);
			this.tbpCustomerSelectScreen.Controls.Add(this.btnSearchCustomer);
			this.tbpCustomerSelectScreen.Controls.Add(this.txtCustomerSearchInput);
			this.tbpCustomerSelectScreen.Controls.Add(this.lblCustomerSelectInputTitle);
			this.tbpCustomerSelectScreen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbpCustomerSelectScreen.Location = new System.Drawing.Point(4, 24);
			this.tbpCustomerSelectScreen.Name = "tbpCustomerSelectScreen";
			this.tbpCustomerSelectScreen.Size = new System.Drawing.Size(1074, 675);
			this.tbpCustomerSelectScreen.TabIndex = 2;
			this.tbpCustomerSelectScreen.Text = "Customer Selection";
			// 
			// grbCustomerAddFields
			// 
			this.grbCustomerAddFields.Controls.Add(this.btnEditCustomerCancel);
			this.grbCustomerAddFields.Controls.Add(this.chbIsComercial);
			this.grbCustomerAddFields.Controls.Add(this.btnCustomerAdd);
			this.grbCustomerAddFields.Controls.Add(this.lblCustomerAddInstructions);
			this.grbCustomerAddFields.Controls.Add(this.rtxtCustomerAddInstructions);
			this.grbCustomerAddFields.Controls.Add(this.lblCustomerAddAddress);
			this.grbCustomerAddFields.Controls.Add(this.txtCustomerAddAddress);
			this.grbCustomerAddFields.Controls.Add(this.lblCustomerAddEmail);
			this.grbCustomerAddFields.Controls.Add(this.txtCustomerAddEmail);
			this.grbCustomerAddFields.Controls.Add(this.lblCustomerAddPhone);
			this.grbCustomerAddFields.Controls.Add(this.txtCustomerAddPhone);
			this.grbCustomerAddFields.Controls.Add(this.lblAddCustomerName);
			this.grbCustomerAddFields.Controls.Add(this.txtCustomerAddName);
			this.grbCustomerAddFields.Controls.Add(this.lblCustomerAddHint);
			this.grbCustomerAddFields.Location = new System.Drawing.Point(3, 394);
			this.grbCustomerAddFields.Name = "grbCustomerAddFields";
			this.grbCustomerAddFields.Size = new System.Drawing.Size(824, 278);
			this.grbCustomerAddFields.TabIndex = 9;
			this.grbCustomerAddFields.TabStop = false;
			this.grbCustomerAddFields.Text = "Customer Add/Edit Fields";
			// 
			// btnEditCustomerCancel
			// 
			this.btnEditCustomerCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnEditCustomerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEditCustomerCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEditCustomerCancel.Location = new System.Drawing.Point(604, 15);
			this.btnEditCustomerCancel.Name = "btnEditCustomerCancel";
			this.btnEditCustomerCancel.Size = new System.Drawing.Size(214, 32);
			this.btnEditCustomerCancel.TabIndex = 21;
			this.btnEditCustomerCancel.Text = "Cancel Edit / Clear Selection";
			this.btnEditCustomerCancel.UseVisualStyleBackColor = false;
			this.btnEditCustomerCancel.Click += new System.EventHandler(this.btnEditCustomerCancel_Click);
			// 
			// chbIsComercial
			// 
			this.chbIsComercial.AutoSize = true;
			this.chbIsComercial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.chbIsComercial.Location = new System.Drawing.Point(430, 94);
			this.chbIsComercial.Name = "chbIsComercial";
			this.chbIsComercial.Size = new System.Drawing.Size(165, 21);
			this.chbIsComercial.TabIndex = 20;
			this.chbIsComercial.Text = "Is Comercial Customer";
			this.chbIsComercial.UseVisualStyleBackColor = true;
			// 
			// btnCustomerAdd
			// 
			this.btnCustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCustomerAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCustomerAdd.Location = new System.Drawing.Point(646, 113);
			this.btnCustomerAdd.Name = "btnCustomerAdd";
			this.btnCustomerAdd.Size = new System.Drawing.Size(172, 23);
			this.btnCustomerAdd.TabIndex = 18;
			this.btnCustomerAdd.Text = "ADD Customer";
			this.btnCustomerAdd.UseVisualStyleBackColor = false;
			this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
			// 
			// lblCustomerAddInstructions
			// 
			this.lblCustomerAddInstructions.AutoSize = true;
			this.lblCustomerAddInstructions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerAddInstructions.Location = new System.Drawing.Point(6, 122);
			this.lblCustomerAddInstructions.Name = "lblCustomerAddInstructions";
			this.lblCustomerAddInstructions.Size = new System.Drawing.Size(148, 17);
			this.lblCustomerAddInstructions.TabIndex = 17;
			this.lblCustomerAddInstructions.Text = "Customer Instructions:";
			// 
			// rtxtCustomerAddInstructions
			// 
			this.rtxtCustomerAddInstructions.Location = new System.Drawing.Point(6, 142);
			this.rtxtCustomerAddInstructions.Name = "rtxtCustomerAddInstructions";
			this.rtxtCustomerAddInstructions.Size = new System.Drawing.Size(812, 130);
			this.rtxtCustomerAddInstructions.TabIndex = 16;
			this.rtxtCustomerAddInstructions.Text = "";
			// 
			// lblCustomerAddAddress
			// 
			this.lblCustomerAddAddress.AutoSize = true;
			this.lblCustomerAddAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerAddAddress.Location = new System.Drawing.Point(6, 95);
			this.lblCustomerAddAddress.Name = "lblCustomerAddAddress";
			this.lblCustomerAddAddress.Size = new System.Drawing.Size(61, 17);
			this.lblCustomerAddAddress.TabIndex = 15;
			this.lblCustomerAddAddress.Text = "Address:";
			// 
			// txtCustomerAddAddress
			// 
			this.txtCustomerAddAddress.Location = new System.Drawing.Point(73, 93);
			this.txtCustomerAddAddress.Name = "txtCustomerAddAddress";
			this.txtCustomerAddAddress.PlaceholderText = "Customer Address (Input)";
			this.txtCustomerAddAddress.Size = new System.Drawing.Size(351, 24);
			this.txtCustomerAddAddress.TabIndex = 14;
			// 
			// lblCustomerAddEmail
			// 
			this.lblCustomerAddEmail.AutoSize = true;
			this.lblCustomerAddEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerAddEmail.Location = new System.Drawing.Point(483, 43);
			this.lblCustomerAddEmail.Name = "lblCustomerAddEmail";
			this.lblCustomerAddEmail.Size = new System.Drawing.Size(46, 17);
			this.lblCustomerAddEmail.TabIndex = 13;
			this.lblCustomerAddEmail.Text = "Email:";
			// 
			// txtCustomerAddEmail
			// 
			this.txtCustomerAddEmail.Location = new System.Drawing.Point(483, 63);
			this.txtCustomerAddEmail.Name = "txtCustomerAddEmail";
			this.txtCustomerAddEmail.PlaceholderText = "Customer Email (Input)";
			this.txtCustomerAddEmail.Size = new System.Drawing.Size(232, 24);
			this.txtCustomerAddEmail.TabIndex = 12;
			// 
			// lblCustomerAddPhone
			// 
			this.lblCustomerAddPhone.AutoSize = true;
			this.lblCustomerAddPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerAddPhone.Location = new System.Drawing.Point(197, 43);
			this.lblCustomerAddPhone.Name = "lblCustomerAddPhone";
			this.lblCustomerAddPhone.Size = new System.Drawing.Size(236, 17);
			this.lblCustomerAddPhone.TabIndex = 11;
			this.lblCustomerAddPhone.Text = "Phone#: EX: 555-555-5555 (Required)";
			// 
			// txtCustomerAddPhone
			// 
			this.txtCustomerAddPhone.Location = new System.Drawing.Point(197, 63);
			this.txtCustomerAddPhone.Name = "txtCustomerAddPhone";
			this.txtCustomerAddPhone.PlaceholderText = "Customer Phone# (Input)";
			this.txtCustomerAddPhone.Size = new System.Drawing.Size(280, 24);
			this.txtCustomerAddPhone.TabIndex = 10;
			// 
			// lblAddCustomerName
			// 
			this.lblAddCustomerName.AutoSize = true;
			this.lblAddCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAddCustomerName.Location = new System.Drawing.Point(6, 43);
			this.lblAddCustomerName.Name = "lblAddCustomerName";
			this.lblAddCustomerName.Size = new System.Drawing.Size(117, 17);
			this.lblAddCustomerName.TabIndex = 9;
			this.lblAddCustomerName.Text = "Name: (Required)";
			// 
			// txtCustomerAddName
			// 
			this.txtCustomerAddName.Location = new System.Drawing.Point(6, 63);
			this.txtCustomerAddName.Name = "txtCustomerAddName";
			this.txtCustomerAddName.PlaceholderText = "Customer Name (Input)";
			this.txtCustomerAddName.Size = new System.Drawing.Size(185, 24);
			this.txtCustomerAddName.TabIndex = 8;
			// 
			// lblCustomerAddHint
			// 
			this.lblCustomerAddHint.AutoSize = true;
			this.lblCustomerAddHint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerAddHint.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblCustomerAddHint.Location = new System.Drawing.Point(6, 15);
			this.lblCustomerAddHint.Name = "lblCustomerAddHint";
			this.lblCustomerAddHint.Size = new System.Drawing.Size(464, 20);
			this.lblCustomerAddHint.TabIndex = 7;
			this.lblCustomerAddHint.Text = "ONLY add customer if NO RESULTS for that customer was found!";
			// 
			// lblCustomerSearchResultErrors
			// 
			this.lblCustomerSearchResultErrors.AutoSize = true;
			this.lblCustomerSearchResultErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblCustomerSearchResultErrors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerSearchResultErrors.ForeColor = System.Drawing.Color.Red;
			this.lblCustomerSearchResultErrors.Location = new System.Drawing.Point(419, 49);
			this.lblCustomerSearchResultErrors.Name = "lblCustomerSearchResultErrors";
			this.lblCustomerSearchResultErrors.Size = new System.Drawing.Size(408, 20);
			this.lblCustomerSearchResultErrors.TabIndex = 6;
			this.lblCustomerSearchResultErrors.Text = "No Customer Found. Search Again Or add New Customer";
			// 
			// btnConfirmCustomerSelection
			// 
			this.btnConfirmCustomerSelection.BackColor = System.Drawing.Color.DarkOrange;
			this.btnConfirmCustomerSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConfirmCustomerSelection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnConfirmCustomerSelection.Location = new System.Drawing.Point(847, 631);
			this.btnConfirmCustomerSelection.Name = "btnConfirmCustomerSelection";
			this.btnConfirmCustomerSelection.Size = new System.Drawing.Size(224, 41);
			this.btnConfirmCustomerSelection.TabIndex = 5;
			this.btnConfirmCustomerSelection.Text = "Confirm Selected Customer";
			this.btnConfirmCustomerSelection.UseVisualStyleBackColor = false;
			this.btnConfirmCustomerSelection.Click += new System.EventHandler(this.btnConfirmCustomerSelection_Click);
			// 
			// lblCustomerSearchResultsTitle
			// 
			this.lblCustomerSearchResultsTitle.AutoSize = true;
			this.lblCustomerSearchResultsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerSearchResultsTitle.Location = new System.Drawing.Point(338, 86);
			this.lblCustomerSearchResultsTitle.Name = "lblCustomerSearchResultsTitle";
			this.lblCustomerSearchResultsTitle.Size = new System.Drawing.Size(216, 40);
			this.lblCustomerSearchResultsTitle.TabIndex = 4;
			this.lblCustomerSearchResultsTitle.Text = "Search Results\r\n(Select a Customer From List)";
			this.lblCustomerSearchResultsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvCustomerSearchResults
			// 
			this.dgvCustomerSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCustomerSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerSearchResults.Location = new System.Drawing.Point(20, 129);
			this.dgvCustomerSearchResults.MultiSelect = false;
			this.dgvCustomerSearchResults.Name = "dgvCustomerSearchResults";
			this.dgvCustomerSearchResults.ReadOnly = true;
			this.dgvCustomerSearchResults.RowTemplate.Height = 25;
			this.dgvCustomerSearchResults.Size = new System.Drawing.Size(844, 259);
			this.dgvCustomerSearchResults.TabIndex = 3;
			this.dgvCustomerSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerSearchResults_CellClick);
			// 
			// btnSearchCustomer
			// 
			this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSearchCustomer.Location = new System.Drawing.Point(338, 48);
			this.btnSearchCustomer.Name = "btnSearchCustomer";
			this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnSearchCustomer.TabIndex = 2;
			this.btnSearchCustomer.Text = "Search";
			this.btnSearchCustomer.UseVisualStyleBackColor = false;
			this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
			// 
			// txtCustomerSearchInput
			// 
			this.txtCustomerSearchInput.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCustomerSearchInput.Location = new System.Drawing.Point(20, 48);
			this.txtCustomerSearchInput.Name = "txtCustomerSearchInput";
			this.txtCustomerSearchInput.PlaceholderText = "Search Input Box";
			this.txtCustomerSearchInput.Size = new System.Drawing.Size(312, 24);
			this.txtCustomerSearchInput.TabIndex = 1;
			// 
			// lblCustomerSelectInputTitle
			// 
			this.lblCustomerSelectInputTitle.AutoSize = true;
			this.lblCustomerSelectInputTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerSelectInputTitle.Location = new System.Drawing.Point(20, 26);
			this.lblCustomerSelectInputTitle.Name = "lblCustomerSelectInputTitle";
			this.lblCustomerSelectInputTitle.Size = new System.Drawing.Size(427, 19);
			this.lblCustomerSelectInputTitle.TabIndex = 0;
			this.lblCustomerSelectInputTitle.Text = "Search: Customer ID \\ Name \\ Phone# Ex: 555-637-1234\\ Email";
			// 
			// tbpOrderEditScreen
			// 
			this.tbpOrderEditScreen.BackColor = System.Drawing.Color.White;
			this.tbpOrderEditScreen.Controls.Add(this.lblDeleteWarning);
			this.tbpOrderEditScreen.Controls.Add(this.lblViewOrderInfo);
			this.tbpOrderEditScreen.Controls.Add(this.lblMarkStatus);
			this.tbpOrderEditScreen.Controls.Add(this.lblPrintTickets);
			this.tbpOrderEditScreen.Controls.Add(this.btnPrintEmployeeCopy);
			this.tbpOrderEditScreen.Controls.Add(this.btnDeleteOrder);
			this.tbpOrderEditScreen.Controls.Add(this.btnPrintCustomerTicket);
			this.tbpOrderEditScreen.Controls.Add(this.btnPrintBasketTicket);
			this.tbpOrderEditScreen.Controls.Add(this.btnMarkPaid);
			this.tbpOrderEditScreen.Controls.Add(this.btnMarkPickup);
			this.tbpOrderEditScreen.Controls.Add(this.btnViewCustomerInfo);
			this.tbpOrderEditScreen.Controls.Add(this.btnViewOrderInstructions);
			this.tbpOrderEditScreen.Controls.Add(this.lblSearchResults);
			this.tbpOrderEditScreen.Controls.Add(this.btnSearchByCustomerID);
			this.tbpOrderEditScreen.Controls.Add(this.dgvOrderSelectList);
			this.tbpOrderEditScreen.Controls.Add(this.txtCustomerID);
			this.tbpOrderEditScreen.Controls.Add(this.lblCurrentCustomerID);
			this.tbpOrderEditScreen.Controls.Add(this.btnLookupCustID);
			this.tbpOrderEditScreen.Controls.Add(this.lblCustomerIdSearch);
			this.tbpOrderEditScreen.Controls.Add(this.btnSearchOrderNum);
			this.tbpOrderEditScreen.Controls.Add(this.lblOrderNumberInput);
			this.tbpOrderEditScreen.Controls.Add(this.txtOrderNumSearch);
			this.tbpOrderEditScreen.Controls.Add(this.lblOrderNumberSearch);
			this.tbpOrderEditScreen.Location = new System.Drawing.Point(4, 24);
			this.tbpOrderEditScreen.Name = "tbpOrderEditScreen";
			this.tbpOrderEditScreen.Size = new System.Drawing.Size(1074, 675);
			this.tbpOrderEditScreen.TabIndex = 3;
			this.tbpOrderEditScreen.Text = "Order Search";
			// 
			// lblDeleteWarning
			// 
			this.lblDeleteWarning.AutoSize = true;
			this.lblDeleteWarning.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblDeleteWarning.Location = new System.Drawing.Point(922, 588);
			this.lblDeleteWarning.Name = "lblDeleteWarning";
			this.lblDeleteWarning.Size = new System.Drawing.Size(113, 40);
			this.lblDeleteWarning.TabIndex = 22;
			this.lblDeleteWarning.Text = "WARNING!\r\nNo Going Back\r\n";
			this.lblDeleteWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblViewOrderInfo
			// 
			this.lblViewOrderInfo.AutoSize = true;
			this.lblViewOrderInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblViewOrderInfo.Location = new System.Drawing.Point(44, 560);
			this.lblViewOrderInfo.Name = "lblViewOrderInfo";
			this.lblViewOrderInfo.Size = new System.Drawing.Size(120, 20);
			this.lblViewOrderInfo.TabIndex = 21;
			this.lblViewOrderInfo.Text = "View Order Info";
			// 
			// lblMarkStatus
			// 
			this.lblMarkStatus.AutoSize = true;
			this.lblMarkStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMarkStatus.Location = new System.Drawing.Point(226, 558);
			this.lblMarkStatus.Name = "lblMarkStatus";
			this.lblMarkStatus.Size = new System.Drawing.Size(152, 20);
			this.lblMarkStatus.TabIndex = 20;
			this.lblMarkStatus.Text = "Update Order Status";
			// 
			// lblPrintTickets
			// 
			this.lblPrintTickets.AutoSize = true;
			this.lblPrintTickets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblPrintTickets.Location = new System.Drawing.Point(422, 558);
			this.lblPrintTickets.Name = "lblPrintTickets";
			this.lblPrintTickets.Size = new System.Drawing.Size(140, 20);
			this.lblPrintTickets.TabIndex = 19;
			this.lblPrintTickets.Text = "Print Order Tickets";
			// 
			// btnPrintEmployeeCopy
			// 
			this.btnPrintEmployeeCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPrintEmployeeCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrintEmployeeCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPrintEmployeeCopy.Location = new System.Drawing.Point(399, 645);
			this.btnPrintEmployeeCopy.Name = "btnPrintEmployeeCopy";
			this.btnPrintEmployeeCopy.Size = new System.Drawing.Size(191, 23);
			this.btnPrintEmployeeCopy.TabIndex = 18;
			this.btnPrintEmployeeCopy.Text = "Print Employee Ticket";
			this.btnPrintEmployeeCopy.UseVisualStyleBackColor = false;
			this.btnPrintEmployeeCopy.Click += new System.EventHandler(this.btnPrintEmployeeCopy_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
			this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
			this.btnDeleteOrder.Location = new System.Drawing.Point(880, 631);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(191, 36);
			this.btnDeleteOrder.TabIndex = 17;
			this.btnDeleteOrder.Text = "DELETE ORDER";
			this.btnDeleteOrder.UseVisualStyleBackColor = false;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// btnPrintCustomerTicket
			// 
			this.btnPrintCustomerTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPrintCustomerTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrintCustomerTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPrintCustomerTicket.Location = new System.Drawing.Point(399, 613);
			this.btnPrintCustomerTicket.Name = "btnPrintCustomerTicket";
			this.btnPrintCustomerTicket.Size = new System.Drawing.Size(191, 23);
			this.btnPrintCustomerTicket.TabIndex = 16;
			this.btnPrintCustomerTicket.Text = "Print Customer Ticket";
			this.btnPrintCustomerTicket.UseVisualStyleBackColor = false;
			this.btnPrintCustomerTicket.Click += new System.EventHandler(this.btnPrintCustomerTicket_Click);
			// 
			// btnPrintBasketTicket
			// 
			this.btnPrintBasketTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPrintBasketTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrintBasketTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPrintBasketTicket.Location = new System.Drawing.Point(399, 581);
			this.btnPrintBasketTicket.Name = "btnPrintBasketTicket";
			this.btnPrintBasketTicket.Size = new System.Drawing.Size(191, 23);
			this.btnPrintBasketTicket.TabIndex = 15;
			this.btnPrintBasketTicket.Text = "Print Basket Ticket";
			this.btnPrintBasketTicket.UseVisualStyleBackColor = false;
			this.btnPrintBasketTicket.Click += new System.EventHandler(this.btnPrintBasketTicket_Click);
			// 
			// btnMarkPaid
			// 
			this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMarkPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMarkPaid.Location = new System.Drawing.Point(202, 584);
			this.btnMarkPaid.Name = "btnMarkPaid";
			this.btnMarkPaid.Size = new System.Drawing.Size(191, 23);
			this.btnMarkPaid.TabIndex = 14;
			this.btnMarkPaid.Text = "Mark Paid/UnPaid";
			this.btnMarkPaid.UseVisualStyleBackColor = false;
			this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
			// 
			// btnMarkPickup
			// 
			this.btnMarkPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnMarkPickup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMarkPickup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMarkPickup.Location = new System.Drawing.Point(202, 614);
			this.btnMarkPickup.Name = "btnMarkPickup";
			this.btnMarkPickup.Size = new System.Drawing.Size(191, 23);
			this.btnMarkPickup.TabIndex = 13;
			this.btnMarkPickup.Text = "Mark Picked Up / Not Picked Up";
			this.btnMarkPickup.UseVisualStyleBackColor = false;
			this.btnMarkPickup.Click += new System.EventHandler(this.btnMarkPickup_Click);
			// 
			// btnViewCustomerInfo
			// 
			this.btnViewCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnViewCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnViewCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnViewCustomerInfo.Location = new System.Drawing.Point(5, 614);
			this.btnViewCustomerInfo.Name = "btnViewCustomerInfo";
			this.btnViewCustomerInfo.Size = new System.Drawing.Size(191, 23);
			this.btnViewCustomerInfo.TabIndex = 12;
			this.btnViewCustomerInfo.Text = "View Customer Information";
			this.btnViewCustomerInfo.UseVisualStyleBackColor = false;
			this.btnViewCustomerInfo.Click += new System.EventHandler(this.btnViewCustomerInfo_Click);
			// 
			// btnViewOrderInstructions
			// 
			this.btnViewOrderInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnViewOrderInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnViewOrderInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnViewOrderInstructions.Location = new System.Drawing.Point(5, 585);
			this.btnViewOrderInstructions.Name = "btnViewOrderInstructions";
			this.btnViewOrderInstructions.Size = new System.Drawing.Size(191, 23);
			this.btnViewOrderInstructions.TabIndex = 11;
			this.btnViewOrderInstructions.Text = "View Order Instructions";
			this.btnViewOrderInstructions.UseVisualStyleBackColor = false;
			this.btnViewOrderInstructions.Click += new System.EventHandler(this.btnViewOrderInstructions_Click);
			// 
			// lblSearchResults
			// 
			this.lblSearchResults.AutoSize = true;
			this.lblSearchResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSearchResults.Location = new System.Drawing.Point(5, 128);
			this.lblSearchResults.Name = "lblSearchResults";
			this.lblSearchResults.Size = new System.Drawing.Size(211, 21);
			this.lblSearchResults.TabIndex = 10;
			this.lblSearchResults.Text = "Search Results (Select List)";
			// 
			// btnSearchByCustomerID
			// 
			this.btnSearchByCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSearchByCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearchByCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSearchByCustomerID.Location = new System.Drawing.Point(433, 83);
			this.btnSearchByCustomerID.Name = "btnSearchByCustomerID";
			this.btnSearchByCustomerID.Size = new System.Drawing.Size(163, 23);
			this.btnSearchByCustomerID.TabIndex = 9;
			this.btnSearchByCustomerID.Text = "Search by Customer ID";
			this.btnSearchByCustomerID.UseVisualStyleBackColor = false;
			this.btnSearchByCustomerID.Click += new System.EventHandler(this.btnSearchByCustomerID_Click);
			// 
			// dgvOrderSelectList
			// 
			this.dgvOrderSelectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvOrderSelectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderSelectList.Location = new System.Drawing.Point(5, 152);
			this.dgvOrderSelectList.MultiSelect = false;
			this.dgvOrderSelectList.Name = "dgvOrderSelectList";
			this.dgvOrderSelectList.ReadOnly = true;
			this.dgvOrderSelectList.RowTemplate.Height = 25;
			this.dgvOrderSelectList.Size = new System.Drawing.Size(806, 282);
			this.dgvOrderSelectList.TabIndex = 8;
			this.dgvOrderSelectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderSelectList_CellClick);
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtCustomerID.Location = new System.Drawing.Point(265, 84);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.PlaceholderText = "Customer ID (Input)";
			this.txtCustomerID.Size = new System.Drawing.Size(162, 23);
			this.txtCustomerID.TabIndex = 7;
			// 
			// lblCurrentCustomerID
			// 
			this.lblCurrentCustomerID.AutoSize = true;
			this.lblCurrentCustomerID.Location = new System.Drawing.Point(140, 87);
			this.lblCurrentCustomerID.Name = "lblCurrentCustomerID";
			this.lblCurrentCustomerID.Size = new System.Drawing.Size(119, 15);
			this.lblCurrentCustomerID.TabIndex = 6;
			this.lblCurrentCustomerID.Text = "Current Customer ID:";
			// 
			// btnLookupCustID
			// 
			this.btnLookupCustID.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnLookupCustID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLookupCustID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnLookupCustID.Location = new System.Drawing.Point(5, 84);
			this.btnLookupCustID.Name = "btnLookupCustID";
			this.btnLookupCustID.Size = new System.Drawing.Size(129, 23);
			this.btnLookupCustID.TabIndex = 5;
			this.btnLookupCustID.Text = "Customer Id Lookup";
			this.btnLookupCustID.UseVisualStyleBackColor = false;
			this.btnLookupCustID.Click += new System.EventHandler(this.btnLookupCustID_Click);
			// 
			// lblCustomerIdSearch
			// 
			this.lblCustomerIdSearch.AutoSize = true;
			this.lblCustomerIdSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerIdSearch.Location = new System.Drawing.Point(5, 60);
			this.lblCustomerIdSearch.Name = "lblCustomerIdSearch";
			this.lblCustomerIdSearch.Size = new System.Drawing.Size(284, 21);
			this.lblCustomerIdSearch.TabIndex = 4;
			this.lblCustomerIdSearch.Text = "OR Search All Order by Customer ID:";
			// 
			// btnSearchOrderNum
			// 
			this.btnSearchOrderNum.BackColor = System.Drawing.Color.Aquamarine;
			this.btnSearchOrderNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearchOrderNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSearchOrderNum.Location = new System.Drawing.Point(268, 29);
			this.btnSearchOrderNum.Name = "btnSearchOrderNum";
			this.btnSearchOrderNum.Size = new System.Drawing.Size(182, 23);
			this.btnSearchOrderNum.TabIndex = 3;
			this.btnSearchOrderNum.Text = "Search by Order Number";
			this.btnSearchOrderNum.UseVisualStyleBackColor = false;
			this.btnSearchOrderNum.Click += new System.EventHandler(this.btnSearchOrderNum_Click);
			// 
			// lblOrderNumberInput
			// 
			this.lblOrderNumberInput.AutoSize = true;
			this.lblOrderNumberInput.Location = new System.Drawing.Point(5, 36);
			this.lblOrderNumberInput.Name = "lblOrderNumberInput";
			this.lblOrderNumberInput.Size = new System.Drawing.Size(87, 15);
			this.lblOrderNumberInput.TabIndex = 2;
			this.lblOrderNumberInput.Text = "Order Number:";
			// 
			// txtOrderNumSearch
			// 
			this.txtOrderNumSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtOrderNumSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtOrderNumSearch.Location = new System.Drawing.Point(96, 31);
			this.txtOrderNumSearch.Name = "txtOrderNumSearch";
			this.txtOrderNumSearch.PlaceholderText = "Order Number (Input)";
			this.txtOrderNumSearch.Size = new System.Drawing.Size(166, 23);
			this.txtOrderNumSearch.TabIndex = 1;
			// 
			// lblOrderNumberSearch
			// 
			this.lblOrderNumberSearch.AutoSize = true;
			this.lblOrderNumberSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblOrderNumberSearch.Location = new System.Drawing.Point(3, 5);
			this.lblOrderNumberSearch.Name = "lblOrderNumberSearch";
			this.lblOrderNumberSearch.Size = new System.Drawing.Size(353, 21);
			this.lblOrderNumberSearch.TabIndex = 0;
			this.lblOrderNumberSearch.Text = "Input Order Number to Search for that Order:";
			// 
			// Order_ID
			// 
			this.Order_ID.HeaderText = "Column1";
			this.Order_ID.Name = "Order_ID";
			// 
			// tbpCouponCheckScreen
			// 
			this.tbpCouponCheckScreen.Controls.Add(this.lblCouponCodeScreenResultTitleExpDate);
			this.tbpCouponCheckScreen.Controls.Add(this.lblCouponCodeScreenResultTitleCouponCode);
			this.tbpCouponCheckScreen.Controls.Add(this.btnCouponCodeScreenCheckCode);
			this.tbpCouponCheckScreen.Controls.Add(this.lblCouponCodeScreenCodeInput);
			this.tbpCouponCheckScreen.Controls.Add(this.txtCouponCodeScreenCodeInput);
			this.tbpCouponCheckScreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbpCouponCheckScreen.Location = new System.Drawing.Point(4, 24);
			this.tbpCouponCheckScreen.Name = "tbpCouponCheckScreen";
			this.tbpCouponCheckScreen.Size = new System.Drawing.Size(1074, 675);
			this.tbpCouponCheckScreen.TabIndex = 4;
			this.tbpCouponCheckScreen.Text = "Coupon check";
			this.tbpCouponCheckScreen.UseVisualStyleBackColor = true;
			// 
			// txtCouponCodeScreenCodeInput
			// 
			this.txtCouponCodeScreenCodeInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCouponCodeScreenCodeInput.Location = new System.Drawing.Point(18, 39);
			this.txtCouponCodeScreenCodeInput.Name = "txtCouponCodeScreenCodeInput";
			this.txtCouponCodeScreenCodeInput.PlaceholderText = "Coupon Code Input";
			this.txtCouponCodeScreenCodeInput.Size = new System.Drawing.Size(244, 25);
			this.txtCouponCodeScreenCodeInput.TabIndex = 0;
			// 
			// lblCouponCodeScreenCodeInput
			// 
			this.lblCouponCodeScreenCodeInput.AutoSize = true;
			this.lblCouponCodeScreenCodeInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCouponCodeScreenCodeInput.Location = new System.Drawing.Point(18, 16);
			this.lblCouponCodeScreenCodeInput.Name = "lblCouponCodeScreenCodeInput";
			this.lblCouponCodeScreenCodeInput.Size = new System.Drawing.Size(147, 20);
			this.lblCouponCodeScreenCodeInput.TabIndex = 1;
			this.lblCouponCodeScreenCodeInput.Text = "Check Coupon Code";
			// 
			// btnCouponCodeScreenCheckCode
			// 
			this.btnCouponCodeScreenCheckCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCouponCodeScreenCheckCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCouponCodeScreenCheckCode.Location = new System.Drawing.Point(268, 41);
			this.btnCouponCodeScreenCheckCode.Name = "btnCouponCodeScreenCheckCode";
			this.btnCouponCodeScreenCheckCode.Size = new System.Drawing.Size(102, 23);
			this.btnCouponCodeScreenCheckCode.TabIndex = 2;
			this.btnCouponCodeScreenCheckCode.Text = "Check Code";
			this.btnCouponCodeScreenCheckCode.UseVisualStyleBackColor = false;
			// 
			// lblCouponCodeScreenResultTitleCouponCode
			// 
			this.lblCouponCodeScreenResultTitleCouponCode.AutoSize = true;
			this.lblCouponCodeScreenResultTitleCouponCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCouponCodeScreenResultTitleCouponCode.Location = new System.Drawing.Point(18, 94);
			this.lblCouponCodeScreenResultTitleCouponCode.Name = "lblCouponCodeScreenResultTitleCouponCode";
			this.lblCouponCodeScreenResultTitleCouponCode.Size = new System.Drawing.Size(106, 20);
			this.lblCouponCodeScreenResultTitleCouponCode.TabIndex = 3;
			this.lblCouponCodeScreenResultTitleCouponCode.Text = "Coupon Code:";
			// 
			// lblCouponCodeScreenResultTitleExpDate
			// 
			this.lblCouponCodeScreenResultTitleExpDate.AutoSize = true;
			this.lblCouponCodeScreenResultTitleExpDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCouponCodeScreenResultTitleExpDate.Location = new System.Drawing.Point(49, 125);
			this.lblCouponCodeScreenResultTitleExpDate.Name = "lblCouponCodeScreenResultTitleExpDate";
			this.lblCouponCodeScreenResultTitleExpDate.Size = new System.Drawing.Size(75, 20);
			this.lblCouponCodeScreenResultTitleExpDate.TabIndex = 4;
			this.lblCouponCodeScreenResultTitleExpDate.Text = "Exp Date:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(1287, 727);
			this.Controls.Add(this.tbcScreens);
			this.Controls.Add(this.panMenusSideBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Laundro Drop - Order App";
			this.panMenusSideBar.ResumeLayout(false);
			this.panMenusSideBar.PerformLayout();
			this.tbcScreens.ResumeLayout(false);
			this.tbpOrderCreateScreen.ResumeLayout(false);
			this.tbpOrderCreateScreen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentCustomerDisplayOrderScreen)).EndInit();
			this.grbOther.ResumeLayout(false);
			this.grbOther.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupHorseBlanket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupPillows)).EndInit();
			this.grbSleepingBags.ResumeLayout(false);
			this.grbSleepingBags.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupSleepingBagsLarge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupSleepingBagsSmall)).EndInit();
			this.grbRugs.ResumeLayout(false);
			this.grbRugs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupRugsLarge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupRugsSmall)).EndInit();
			this.grbBlankets.ResumeLayout(false);
			this.grbBlankets.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsKing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsQueen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsFull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupBlanketsTwin)).EndInit();
			this.grbComforters.ResumeLayout(false);
			this.grbComforters.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterKing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterQueen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterFull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupComforterTwin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupLaundryPounds)).EndInit();
			this.tbpCustomerSelectScreen.ResumeLayout(false);
			this.tbpCustomerSelectScreen.PerformLayout();
			this.grbCustomerAddFields.ResumeLayout(false);
			this.grbCustomerAddFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSearchResults)).EndInit();
			this.tbpOrderEditScreen.ResumeLayout(false);
			this.tbpOrderEditScreen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderSelectList)).EndInit();
			this.tbpCouponCheckScreen.ResumeLayout(false);
			this.tbpCouponCheckScreen.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panMenusSideBar;
		private Button btnScreenHelp;
		private Button btnMenuOrderLookup;
		private Button btnMenuCreateOrders;
		private Label lblMenusTitle;
		private TabControl tbcScreens;
		private TabPage tbpOrderCreateScreen;
		private TabPage tbpCustomerSelectScreen;
		private TabPage tbpOrderEditScreen;
		private Label lblStep1;
		private Button btnCustomerSelectAdd;
		private GroupBox grbComforters;
		private Label lblLaundryPounds;
		private NumericUpDown nupLaundryPounds;
		private Label lblCurrentCustomer;
		private Label lblComfortersTwin;
		private NumericUpDown nupComforterKing;
		private NumericUpDown nupComforterQueen;
		private NumericUpDown nupComforterFull;
		private NumericUpDown nupComforterTwin;
		private Label lblComfortersFull;
		private Label lblComfortersKing;
		private Label lblComfortersQueen;
		private GroupBox grbBlankets;
		private Label lblBlanketsKing;
		private Label lblBlanketsQueen;
		private Label lblBlanketsFull;
		private Label lblBlanketsTwin;
		private NumericUpDown nupBlanketsKing;
		private NumericUpDown nupBlanketsQueen;
		private NumericUpDown nupBlanketsFull;
		private NumericUpDown nupBlanketsTwin;
		private RichTextBox rtxtOrderInstructions;
		private GroupBox grbOther;
		private Label lblHorseBlanket;
		private Label lblPillows;
		private NumericUpDown nupHorseBlanket;
		private NumericUpDown nupPillows;
		private GroupBox grbSleepingBags;
		private Label lblSleepingBagsLarge;
		private Label lblSleepingBagsSmall;
		private NumericUpDown nupSleepingBagsLarge;
		private NumericUpDown nupSleepingBagsSmall;
		private GroupBox grbRugs;
		private Label lblRugsLarge;
		private Label lblRugsSmall;
		private NumericUpDown nupRugsLarge;
		private NumericUpDown nupRugsSmall;
		private Label lblOrderInstructions;
		private Button btnCreateOrder;
		private Button btnLookupCustID;
		private Label lblCustomerIdSearch;
		private Button btnSearchOrderNum;
		private Label lblOrderNumberInput;
		private TextBox txtOrderNumSearch;
		private Label lblOrderNumberSearch;
		private DataGridView dgvOrderSelectList;
		private TextBox txtCustomerID;
		private Label lblCurrentCustomerID;
		private DataGridViewTextBoxColumn Order_ID;
		private Label lblDeleteWarning;
		private Label lblViewOrderInfo;
		private Label lblMarkStatus;
		private Label lblPrintTickets;
		private Button btnPrintEmployeeCopy;
		private Button btnDeleteOrder;
		private Button btnPrintCustomerTicket;
		private Button btnPrintBasketTicket;
		private Button btnMarkPaid;
		private Button btnMarkPickup;
		private Button btnViewCustomerInfo;
		private Button btnViewOrderInstructions;
		private Label lblSearchResults;
		private Button btnSearchByCustomerID;
		private Label lblCustomerSearchResultsTitle;
		private DataGridView dgvCustomerSearchResults;
		private Button btnSearchCustomer;
		private TextBox txtCustomerSearchInput;
		private Label lblCustomerSelectInputTitle;
		private Button btnConfirmCustomerSelection;
		private DataGridView dgvCurrentCustomerDisplayOrderScreen;
		private Label lblCustomerSearchResultErrors;
		private Label lblCustomerAddHint;
		private GroupBox grbCustomerAddFields;
		private CheckBox chbIsComercial;
		private Button btnCustomerAdd;
		private Label lblCustomerAddInstructions;
		private RichTextBox rtxtCustomerAddInstructions;
		private Label lblCustomerAddAddress;
		private TextBox txtCustomerAddAddress;
		private Label lblCustomerAddEmail;
		private TextBox txtCustomerAddEmail;
		private Label lblCustomerAddPhone;
		private TextBox txtCustomerAddPhone;
		private Label lblAddCustomerName;
		private TextBox txtCustomerAddName;
		private Button btnAdminResetDbCustomer;
		private Button btnEditCustomerCancel;
		private Label lblOrderScreenTotal;
		private Button btnAdminScreen;
		private TabPage tbpCouponCheckScreen;
		private Label lblCouponCodeScreenResultTitleExpDate;
		private Label lblCouponCodeScreenResultTitleCouponCode;
		private Button btnCouponCodeScreenCheckCode;
		private Label lblCouponCodeScreenCodeInput;
		private TextBox txtCouponCodeScreenCodeInput;
	}
}