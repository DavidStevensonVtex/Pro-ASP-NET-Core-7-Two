﻿// Listing 28.10 Binding a complex type in the FormController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;

namespace WebApp.Controllers
{
    public class FormController : Controller
    {
        private DataContext context;

        public FormController(DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> Index(long? id)
        {
            ViewBag.Categories = 
                new SelectList(context.Categories, "CategoryId", "Name");
            return View("Form", await context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .FirstOrDefaultAsync(p => id == null || p.ProductId == id) 
                ?? new() { Name = string.Empty });
        }

        [HttpPost]
        public IActionResult SubmitForm(Product product)
        {
            TempData["product"] = JsonSerializer.Serialize(product);
            return RedirectToAction(nameof(Results));
        }

        public IActionResult Results()
        {
            return View();
        }
    }
}
