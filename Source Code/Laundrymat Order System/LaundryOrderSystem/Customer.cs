using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderSystem
{
	public class Customer
	{

		public string _customerID;
		public string _name;
		public string? _email;
		public string _phone;
		public string? _address;

		public Customer(string customerID, string name, string phone, string? address, string? email)
		{
			_customerID = customerID;
			_name = name;
			_phone = phone;
			_address = address;
			_email = email;
		}
	
		public string Id { get { return _customerID; } }
		public string Name { get { return _name;} }
		public string Phone { get { return _phone;} }
		public string Email { get { return _email;} } 

		public string Address { get { return _address; } }


	}
}
