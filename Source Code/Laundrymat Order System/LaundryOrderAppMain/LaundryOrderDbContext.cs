using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryOrderAppMain
{
	public class LaundryOrderDbContext : DbContext
	{
		//Creating our Customers table in the DB
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Prices> Prices { get; set; }
		public DbSet<Coupon> Coupons { get; set; }

		//Conection String
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LaundryOrderSystem;Trusted_Connection=True;MultipleActiveResultSets=True");
		}

		//Give App Seed Data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().HasData(
				new Customer { CustomerID = 1, Name = "Jacob Weinrich", IsComercial = false, Phone = "314-939-9335", Email = "Jacob@segotw.com", Address = "5240 Windswept ln House Springs MO 63051" }
				);
			modelBuilder.Entity<Order>().HasData( new Order { OrderID = 1, CustomerID = 1 } );
			modelBuilder.Entity<Prices>().HasData(
				new Prices { PricesID = 1, Name= "PricePerPound", Price = 1.25}, 
				new Prices { PricesID = 2, Name = "PricePerPound-Comercial", Price = 1.50 }, 

				new Prices { PricesID = 3, Name = "Comforter-Twin", Price = 17 },
				new Prices { PricesID = 4, Name = "Comforter-Full", Price = 18 },
				new Prices { PricesID = 5, Name = "Comforter-Queen", Price = 19 },
				new Prices { PricesID = 6, Name = "Comforter-King", Price = 20 },

				new Prices { PricesID = 7, Name = "Blanket-Twin", Price = 15 },
				new Prices { PricesID = 8, Name = "Blanket-Full", Price = 16 },
				new Prices { PricesID = 9, Name = "Blanket-Queen", Price = 17 },
				new Prices { PricesID = 10, Name = "Blanket-King", Price = 18 },

				new Prices { PricesID = 11, Name = "Rug-Small", Price = 15 },
				new Prices { PricesID = 12, Name = "Rug-Large", Price = 20 },

				new Prices { PricesID = 13, Name = "SleepingBag-Single", Price = 15 },
				new Prices { PricesID = 14, Name = "SleepingBag-Large", Price = 20 },

				new Prices { PricesID = 15, Name = "Pillow", Price = 5 },
				new Prices { PricesID = 16, Name = "HorseBlanket", Price = 25 }



				);
			modelBuilder.Entity<Coupon>().HasData(new Coupon { CouponID = 1, Used = false, ISDropOffServiceCoupon = false, DiscountAmount = null, CreatedDate = DateTime.Now, StartDate = DateTime.Now, ExpDate = DateTime.Now, Instructions = "Start 1 Washer of any Size for Customer", Description = "1 Free Wash Any Size Washer" });
		}

	}
}
