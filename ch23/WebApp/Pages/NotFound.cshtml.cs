// Listing 23.14b The contents of the NotFound.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    public class NotFoundModel : PageModel
    {
        private DataContext context;
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

        public NotFoundModel(DataContext ctx)
        {
            context = ctx;
        }

        public void OnGet(long id = 1)
        {
            Products = context.Products;
        }
    }
}
