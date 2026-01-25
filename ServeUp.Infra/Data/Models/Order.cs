using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }


		public int TableNumber { get; set; }


		public DateTime CreatedOn { get; set; } = DateTime.UtcNow;


		[Column(TypeName = "decimal(18,2)")]
		public decimal TotalPrice { get; set; }


		public ICollection<OrderItem> Orderitems { get; set; } = new List<OrderItem>();
	}
}
