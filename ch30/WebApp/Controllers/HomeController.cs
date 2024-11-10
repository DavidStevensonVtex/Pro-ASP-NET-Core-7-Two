// Listing 30.2 The contents of the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }
    }
}
