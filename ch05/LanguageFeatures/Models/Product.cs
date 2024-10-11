﻿// Listing 5.13 Providing a default value in the Product.cs file in the Models folder

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System;

namespace LanguageFeatures.Models
{
	public class Product
	{
		public required string Name { get; set; } = string.Empty;
		public decimal? Price { get; set; }

		public static Product[] GetProducts()
		{
			Product kayak = new Product { Name = "Kayak", Price = 275M };
			Product lifejacket = new Product {
				// Required member 'Product.Name' must be set in the object initializer or attribute constructor.

			//Name = "Lifejacket", 
				Price = 48.95M
			};

			return new Product[] { kayak, lifejacket, null };
		}
	}
}
