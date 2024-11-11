﻿// Listing 30.13 Filtering all actions in the HomeController.cs file in the Controllers folder

namespace WebApp.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }

        public IActionResult Secure()
        {
            return View("Message", "This is the Secure action on the Home controller");
        }
    }
}