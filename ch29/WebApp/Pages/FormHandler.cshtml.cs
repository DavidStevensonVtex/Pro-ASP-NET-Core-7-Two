// Listing 29.22 Removing explicit validation in the FormHandler.cshtml.cs file in the Pages folder

using WebApp.Validation;

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
                ModelState.PromotePropertyErrors(nameof(Product));
                return Page();
            }
        }
    }
}
