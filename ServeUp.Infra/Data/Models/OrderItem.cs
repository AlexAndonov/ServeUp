using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class OrderItem
	{
		public int OrderId { get; set; }

		[Required]
		[ForeignKey(nameof(OrderId))]
		public Order Order { get; set; } = null!;


		public int MenuItemId { get; set; }
		[Required]
		[ForeignKey(nameof(MenuItemId))]
		public MenuItem MenuItem { get; set; } = null!;


		public int Quantity { get; set; }


		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
	}
}
