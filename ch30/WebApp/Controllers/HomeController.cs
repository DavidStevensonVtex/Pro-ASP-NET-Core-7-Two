﻿// Listing 30.12 Applying a filter in the HomeController.cs file in the Controllers folder

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }

        [RequireHttps]
        public IActionResult Secure()
        {
            return View("Message", "This is the Secure action on the Home controller");
        }
    }
}