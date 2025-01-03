﻿// Listing 5.44 A lambda property  in the Product.cs file in the Models folder

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System;

namespace LanguageFeatures.Models
{
	public class Product
	{
		public string Name { get; set; } = string.Empty;
		public decimal? Price { get; set; }

		public bool NameBeginsWithS => Name.Length > 0 && Name[0] == '0';

		public static Product?[] GetProducts()
		{
			Product kayak = new Product { Name = "Kayak", Price = 275M };
			Product lifejacket = new Product {
				Name = "Lifejacket",
				Price = 48.95M
			};

			return new Product[] { kayak, lifejacket, null };
		}
	}
}
