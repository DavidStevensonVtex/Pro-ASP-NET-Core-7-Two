﻿// Listing 22.1 The contents of the HomeController.cs file in the Controllers folder

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
            return View(await context.Products.FindAsync(id));
        }

        public IActionResult List()
        {
            return View(context.Products);
        }
    }
}
