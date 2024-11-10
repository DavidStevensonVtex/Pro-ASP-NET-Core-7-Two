// Listing 29.14b Validating data in the FormHandler.cshtml.cs file in the Pages folder

using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp.Models;

namespace WebApp.Pages
{
    public class FormHandlerModel : PageModel
    {
        private DataContext context;

        public FormHandlerModel(DataContext dbContext)
        {
            context = dbContext;
        }

        [BindProperty]
        public Product? Product { get; set; } = new() { Name = string.Empty };

        //[BindProperty(Name = "Product.Category")]
        //public Category Category { get; set; } = new() { Name = string.Empty };

        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products
                .OrderBy(p => p.ProductId)
                .FirstAsync(p => p.ProductId == id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.GetValidationState("Product.Price") == ModelValidationState.Valid &&
                Product.Price <= 0)
            {
                ModelState.AddModelError("Product.Price", "Enter a positive price");
            }

            if (ModelState.GetValidationState("Product.Name") == ModelValidationState.Valid &&
                ModelState.GetValidationState("Product.Price") == ModelValidationState.Valid &&
                Product.Name.ToLower().StartsWith("small") &&
                Product.Price > 100)
            {
                ModelState.AddModelError("", "Small products cannot cost more than $100");
            }

            if (ModelState.GetValidationState("Product.CategoryId") == ModelValidationState.Valid &&
                !context.Categories.Any(c => c.CategoryId == Product.CategoryId))
            {
                ModelState.AddModelError("Product.CategoryId", "Enter an existing category ID");
            }

            if (ModelState.GetValidationState("Product.SupplierId") == ModelValidationState.Valid &&
                !context.Suppliers.Any(s => s.SupplierId == Product.SupplierId))
            {
                ModelState.AddModelError("Product.SupplierId", "Enter an existing Supplier ID");
            }

            if (ModelState.IsValid)
            {
                TempData["name"] = Product.Name;
                TempData["price"] = Product.Price.ToString();
                TempData["categoryId"] = Product.CategoryId.ToString();
                TempData["supplieryId"] = Product.SupplierId.ToString();
                return RedirectToPage("FormResults");
            }
            else
            {
                return Page();
            }
        }
    }
}
