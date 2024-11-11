﻿// Listing 30.34 Applying a filter in the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Controllers
{
    [HttpsOnly]
    [ResultDiagnostics]
    [GuidResponse]
    [GuidResponse]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }
    }
}