using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class MenuItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Ingredients { get; set; }
		public string Picture { get; set; }
		public decimal Price { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public ICollection<OrderItem> OrderItems { get; set; }
	}
}
