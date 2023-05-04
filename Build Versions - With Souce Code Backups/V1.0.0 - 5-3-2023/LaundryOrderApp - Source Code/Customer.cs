using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderAppMain
{
	public class Customer
	{

		public int CustomerID { get; set; }
		public bool IsComercial { get; set; } = false;
		public bool IsEnabled { get; set; } = true;
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Instructions { get; set; } = string.Empty;

	


	}
}
