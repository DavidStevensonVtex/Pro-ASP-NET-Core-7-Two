﻿// Listing 5.8 Adding a statement in the HomeController.cs file in the Controllers folder

using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			Product[] products = Product.GetProducts(); 
			return View(new string[] { products[0].Name });
		}
	}
}
