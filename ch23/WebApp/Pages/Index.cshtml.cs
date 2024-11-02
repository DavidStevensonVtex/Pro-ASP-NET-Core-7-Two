// Listing 23.13 Using an explicit result the Index.cshtml.cs file in the Pages folder

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
            return Page();
        }
    }
}
