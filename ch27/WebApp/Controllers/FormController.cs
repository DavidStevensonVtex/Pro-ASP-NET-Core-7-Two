﻿// Listing 27.29 Enabling the anti-forgery feature in the FormController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class FormController : Controller
    {
        private DataContext context;

        public FormController(DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            ViewBag.Categories = 
                new SelectList(context.Categories, "CategoryId", "Name");
            return View("Form", await context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .FirstAsync(p => p.ProductId == id) 
                ?? new() { Name = string.Empty });
        }

        [HttpPost]
        public IActionResult SubmitForm()
        {
            foreach (string key in Request.Form.Keys)
            {
                TempData[key] = string.Join(", ", (string?) Request.Form[key]);
            }

            return RedirectToAction(nameof(Results));
        }

        public IActionResult Results()
        {
            return View();
        }
    }
}
