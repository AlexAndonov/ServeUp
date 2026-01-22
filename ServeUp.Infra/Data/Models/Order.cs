using System;
using System.Collections.Generic;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int TableNumber { get; set; }
		public DateTime CreatedOn { get; set; }
		public decimal TotalPrice { get; set; }
		public IEnumerable<OrderItem> Orderitems { get; set; }
	}
}
