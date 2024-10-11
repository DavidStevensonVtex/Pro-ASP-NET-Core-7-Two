﻿// Listing 5.30 The contents of the MyExtensionMethods.cs file in the Models folder

namespace LanguageFeatures.Models
{
	public static class MyExtensionMethods
	{
		public static decimal TotalPrices(this ShoppingCart cartParam)
		{
			decimal total = 0;
			if(cartParam.Products != null)
			{
				foreach (Product? prod in cartParam.Products)
				{
					total += prod?.Price ?? 0;
				}
			}
			return total;
		}
	}
}
