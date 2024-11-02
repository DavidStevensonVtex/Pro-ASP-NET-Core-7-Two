// Listing 23.18b The contents of the HandlerSelector.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    public class HandlerSelectorModel : PageModel
    {
        private DataContext context;

        public Product? Product { get; set; }

        public HandlerSelectorModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task OnGet(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
        }

        public async Task OnGetRelatedAsync(long id = 1)
        {
            Product = await context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (Product != null && Product.Supplier != null)
            {
                Product.Supplier.Products = null;
            }
            if( Product != null && Product.Category != null)
            {
                Product.Category.Products = null;
            }
        }
    }
}
