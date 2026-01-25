using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ServeUp.Infra.Data.Models
{
	public class MenuItem
	{
		[Key]
		public int Id { get; set; }


		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;


		[Required]
		[MaxLength(300)]
		public string Description { get; set; } = string.Empty;


		[Required]
		[MaxLength(500)]
		public string Ingredients { get; set; } = string.Empty;


		public string? Picture { get; set; }


		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }


		public int CategoryId { get; set; }

		[Required]
		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; } = null!;


		public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
	}
}
