using System;
using System.Collections.Generic;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class Category
	{
		public int Id { get; set; }
		public ICollection<MenuItem> MenuItems { get; set; }
	}
}
