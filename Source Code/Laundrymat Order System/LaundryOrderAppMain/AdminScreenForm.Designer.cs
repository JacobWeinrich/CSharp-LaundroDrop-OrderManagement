namespace LaundryOrderAppMain
{
	partial class AdminScreenForm
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
			this.dgvPricesView = new System.Windows.Forms.DataGridView();
			this.lblItem = new System.Windows.Forms.Label();
			this.btnUpdatePrice = new System.Windows.Forms.Button();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblSelectedItem = new System.Windows.Forms.Label();
			this.nupPriceInput = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dgvPricesView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupPriceInput)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPricesView
			// 
			this.dgvPricesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPricesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPricesView.Location = new System.Drawing.Point(12, 12);
			this.dgvPricesView.MultiSelect = false;
			this.dgvPricesView.Name = "dgvPricesView";
			this.dgvPricesView.ReadOnly = true;
			this.dgvPricesView.RowTemplate.Height = 25;
			this.dgvPricesView.Size = new System.Drawing.Size(776, 234);
			this.dgvPricesView.TabIndex = 0;
			this.dgvPricesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricesView_CellClick);
			// 
			// lblItem
			// 
			this.lblItem.AutoSize = true;
			this.lblItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblItem.Location = new System.Drawing.Point(12, 260);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(50, 20);
			this.lblItem.TabIndex = 2;
			this.lblItem.Text = "Item: ";
			// 
			// btnUpdatePrice
			// 
			this.btnUpdatePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnUpdatePrice.Location = new System.Drawing.Point(191, 292);
			this.btnUpdatePrice.Name = "btnUpdatePrice";
			this.btnUpdatePrice.Size = new System.Drawing.Size(100, 23);
			this.btnUpdatePrice.TabIndex = 3;
			this.btnUpdatePrice.Text = "Update Price";
			this.btnUpdatePrice.UseVisualStyleBackColor = false;
			this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblPrice.Location = new System.Drawing.Point(12, 292);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(47, 20);
			this.lblPrice.TabIndex = 4;
			this.lblPrice.Text = "Price:";
			// 
			// lblSelectedItem
			// 
			this.lblSelectedItem.AutoSize = true;
			this.lblSelectedItem.Location = new System.Drawing.Point(68, 264);
			this.lblSelectedItem.Name = "lblSelectedItem";
			this.lblSelectedItem.Size = new System.Drawing.Size(78, 15);
			this.lblSelectedItem.TabIndex = 5;
			this.lblSelectedItem.Text = "Selected Item";
			// 
			// nupPriceInput
			// 
			this.nupPriceInput.DecimalPlaces = 2;
			this.nupPriceInput.Location = new System.Drawing.Point(65, 291);
			this.nupPriceInput.Name = "nupPriceInput";
			this.nupPriceInput.Size = new System.Drawing.Size(120, 23);
			this.nupPriceInput.TabIndex = 6;
			// 
			// AdminScreenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.nupPriceInput);
			this.Controls.Add(this.lblSelectedItem);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.btnUpdatePrice);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.dgvPricesView);
			this.Name = "AdminScreenForm";
			this.Text = "AdminScreenForm";
			this.Load += new System.EventHandler(this.AdminScreenForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPricesView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupPriceInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvPricesView;
		private Label lblItem;
		private Button btnUpdatePrice;
		private Label lblPrice;
		private Label lblSelectedItem;
		private NumericUpDown nupPriceInput;
	}
}