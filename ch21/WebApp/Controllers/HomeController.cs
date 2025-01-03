﻿// Listing 21.27 Adding an action in the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;

        public HomeController (DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            Product? prod = await context.Products.FindAsync(id);
            if (prod?.CategoryId == 1)
            {
                return View("Watersports", prod);
            }
            else
            {
                return View(prod);
            }
            return View();
        }

        public IActionResult Common()
        {
            return View();
        }

        // An unhandled exception occurred while processing the request.
        // InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.String', 
        //    but this ViewDataDictionary instance requires a model item of type 'WebApp.Models.Product'.

        public IActionResult WrongModel()
        {
            return View("Watersports", "Hello, World!");
        }

        public IActionResult List()
        {
            return View(context.Products);
        }
    }
}
