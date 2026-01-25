using ServeUp.Infra.Constants;
using ServeUp.Infra.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static ServeUp.Infra.Constants.ValidationConstants;

namespace ServeUp.Core.ViewModels
{
	public class MenuItemDto
	{
		public int Id { get; set; }

		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(MenuItemNameMaxLength, MinimumLength = MenuItemNameMinLength)]
		public string Name { get; set; } = string.Empty;


		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(MenuItemDescriptionMaxLength, MinimumLength = MenuItemDescriptionMinLength)]
		public string Description { get; set; } = string.Empty;


		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(MenuItemIngredientsMaxLength, MinimumLength = MenuItemIngredientsMinLength)]
		public string Ingredients { get; set; } = string.Empty;


		public string? Picture { get; set; }


		[Required(ErrorMessage = RequiredErrorMessage)]
		public decimal Price { get; set; }


		public int CategoryId { get; set; }

		[Required(ErrorMessage = RequiredErrorMessage)]
		public string CategoryName { get; set; } = null!;
	}
}
