using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderAppMain
{
	public class Order
	{


		//Order id
		public int OrderID { get; set; }
		//Customer id on order
		public int CustomerID { get; set; }
		//is the customer on the order comercial (for comercial Pricing)
		public bool IsComercial { get; set; } = false;
		//Order Status
		public DateTime CreatedDate { get; set; } = DateTime.Now;

		public bool IsPickedUp { get; set; } = false;
		public DateTime? PickUpDate { get; set; } = null;
		public bool IsPaid { get; set; } = false;
		//Total Price of Order (Calculated based off if comercial and the items on the order)
		public double TotalPrice { get; set; } = 0;
		//Pounds of normal Laundry
		public double LaundryPounds { get; set; } = 0;
		//Comforters
		public int ComfortersTwin { get; set; } = 0;
		public int ComfortersFull { get; set; } = 0;
		public int ComfortersQueen { get; set; } = 0;
		public int ComfortersKing { get; set; } = 0;
		//Blankets
		public int BlanketsTwin { get; set; } = 0;
		public int BlanketsFull { get; set; } = 0;
		public int BlanketsQueen { get; set; } = 0;
		public int BlanketsKing { get; set; } = 0;
		//Rugs
		public int RugsSmall { get; set; } = 0;
		public int RugsLarge { get; set; } = 0;
		//Sleeping Bags
		public int SleepingBagSingle { get; set; } = 0;
		public int SleepingBagDouble { get; set; } = 0;
		//Other
		public int Pillows { get; set; } = 0;
		public int HorseBlankets { get; set; } = 0;
		//Instructions
		public string Instructions { get; set; } = "";




	}
}
