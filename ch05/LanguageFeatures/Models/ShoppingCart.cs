﻿// Listing 5.29 The contents of the ShoppingCart.cs file in the Models folder

namespace LanguageFeatures.Models
{
	public class ShoppingCart
	{
		public IEnumerable<Product?> Products { get; set; }
	}
}
