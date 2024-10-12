﻿// Listing 5.43 A lambda action method in the HomeController.cs file in the Controllers folder

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
        public ViewResult Index() =>
            View("Index", Product.GetProducts().Select(p => p?.Name));
	}
}
