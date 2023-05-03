using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderSystem
{
	public class Order
	{


		//Order id
		private string _orderID;
		//Customer id on order
		private string _customerID;
		//is the customer on the order comercial (for comercial Pricing)
		private bool _isComercial;
		//Total Price of Order (Calculated based off if comercial and the items on the order)
		private double _totalPrice;
		//Pounds of normal Laundry
		private double _laundryPounds;
		//Comforters
		private int _comfortersTwin;
		private int _comfortersFull;
		private int _comfortersQueen;
		private int _comfortersKing;
		//Blankets
		private int _blanketsTwin;
		private int _blanketsFull;
		private int _blanketsQueen;
		private int _blanketsKing;
		//Rugs
		private int _rugsSmall;
		private int _rugsLarge;
		//Sleeping Bags
		private int _sleepingBagSingle;
		private int _sleepingBagDouble;
		//Other
		private int _pillows;
		private int _horseBlankets;
		//Instructions
		private string _instructions;





		//Total Price will be set based off the items on order and if its commercial or not
		public Order(
			//Order id
			string id,
			//customer for order
			string customerID,
			//is the Customer a comercial customer
			bool isComercial,
			//Laundry pounds
			double laundryPounds,
			//Comforters
			int comfortersTwin,
			int comfortersFull,
			int comfortersQueen,
			int comfortersKing,
			//Blankets
			int blanketsTwin,
			int blanketsFull,
			int blanketsQueen,
			int blanketsKing,
			//Rugs
			int rugsSmall,
			int rugsLarge,
			//Sleeping Bags
			int sleepingBagSingle,
			int sleepingBagDouble,
			//Other
			int pillows,
			int horseBlankets,
			//Instructions
			string instructions
			)
		{
			//IDS
			_orderID= id;
			_customerID= customerID;
			//Is cust comercial
			_isComercial= isComercial;
			//Laundry Pounds
			_laundryPounds= laundryPounds;
			//Comforters
			_comfortersTwin= comfortersTwin;
			_comfortersFull= comfortersFull;
			_comfortersQueen= comfortersQueen;
			_comfortersKing= comfortersKing;
			//Blankets
			_blanketsTwin= blanketsTwin;
			_blanketsFull= blanketsFull;
			_blanketsQueen= blanketsQueen;
			_blanketsKing= blanketsKing;
			//Rugs
			_rugsSmall= rugsSmall;
			_rugsLarge=rugsLarge;
			//SleepingBags
			_sleepingBagSingle= sleepingBagSingle;
			_sleepingBagDouble= sleepingBagDouble;
			//OTher
			_pillows= pillows;
			_horseBlankets= horseBlankets;
			//Instructions
			_instructions= instructions;

			double PricePerPound = 1;

			//Total Price Calc
			if (_isComercial)
			{
				PricePerPound = 1.50;
			}
			_totalPrice = PricePerPound * _laundryPounds;
			_totalPrice += _comfortersTwin * 1;
			_totalPrice += _comfortersFull * 1;
			_totalPrice += _comfortersQueen * 1;
			_totalPrice += _comfortersKing * 1;

		}


	}
}
