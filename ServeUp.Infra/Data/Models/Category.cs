using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }



		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = string.Empty;



		[MaxLength(200)]
		public string? Description { get; set; }



		public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
	}
}
