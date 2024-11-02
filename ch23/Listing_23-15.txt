// Listing 23.15 Using a redirection in the Index.cshtml.cs file in the Pages folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private DataContext context;

        public Product? Product { get; set; }

        public IndexModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
            if (Product == null) {
                return RedirectToPage("NotFound");
            }
            return Page();
        }
    }
}
