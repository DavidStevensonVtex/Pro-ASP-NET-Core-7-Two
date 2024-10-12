﻿// Listing 5.60 Hard-coding a name in the HomeController.cs file in the Controllers folder

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            var products = new[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };

            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        }
    }
}
