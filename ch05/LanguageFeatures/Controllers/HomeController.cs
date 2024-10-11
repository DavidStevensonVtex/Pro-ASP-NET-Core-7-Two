﻿// Listing 5.26 Using a target-typed new expression syntax in the HomeController.cs file in the Controllers folder

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			Dictionary<string, Product> products = new()
			{
				["Kayak"] = new Product { Name = "Kayak", Price = 275M },
				["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
			};
			return View("Index", products.Keys);
		}
	}
}
