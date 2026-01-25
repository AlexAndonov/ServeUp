using System;
using System.Collections.Generic;
using System.Text;

namespace ServeUp.Infra.Constants
{
	public static class ValidationConstants
	{
		public const int MenuItemNameMaxLength = 100;
		public const int MenuItemNameMinLength = 3;

		public const int MenuItemDescriptionMaxLength = 300;
		public const int MenuItemDescriptionMinLength = 10;

		public const int MenuItemIngredientsMaxLength = 500;
		public const int MenuItemIngredientsMinLength = 10;

		public const string RequiredErrorMessage = "{0} is required";
		public const string RequiredStringLengthErrorMessage = "{0} should be between {2} and {1} symbols!";
	}
}
