using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderAppMain
{
	public class Coupon
	{

		public int CouponID { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime ExpDate { get; set; }
		public bool Used { get; set; } = false; //Has been used or not?
		public bool ISDropOffServiceCoupon { get; set; } = false;
		public decimal? DiscountAmount { get; set; } = null;
		public string Description { get; set; }
		public string Instructions { get; set; }


	}
}
