﻿// Listing 29.20 Removing explicit validation in the Controllers/FormController.cs file

using Microsoft.AspNetCore.Mvc.ModelBinding;

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
            return View("Form", await context.Products
                    .OrderBy(p => p.ProductId)
                    .FirstOrDefaultAsync(p => id == null || p.ProductId == id));
        }

        [HttpPost]
        public IActionResult SubmitForm(Product product)
        {
            if (ModelState.IsValid)
            {
                TempData["name"] = product.Name;
                TempData["price"] = product.Price.ToString();
                TempData["categoryId"] = product.CategoryId.ToString();
                TempData["supplieryId"] = product.SupplierId.ToString();
                return RedirectToAction(nameof(Results));
            }
            else
            {
                return View("Form");
            }
        }

        public IActionResult Results()
        {
            return View();
        }
    }
}
