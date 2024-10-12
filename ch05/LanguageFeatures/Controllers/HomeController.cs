﻿// Listing 5.45 Using type inference in the HomeController.cs file in the Controllers folder

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            return View("Index", names);
        }
    }
}
