﻿// Listing 6.17 Adding a property the HomeController.cs file in the Controllers folder

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataSource();
        public IActionResult Index()
        {
            return View(dataSource.Products);
        }
    }
}
