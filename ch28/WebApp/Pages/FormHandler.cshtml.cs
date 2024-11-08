// Listing 28.6b Using model binding in the FormHandler.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    //[IgnoreAntiforgeryToken]
    public class FormHandlerModel : PageModel
    {
        private DataContext context;

        public FormHandlerModel(DataContext dbContext)
        {
            context = dbContext;
        }

        public Product? Product { get; set; } = new() { Name = string.Empty };

        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstAsync(p => p.ProductId == id);
        }

        public IActionResult OnPost(string name, decimal price)
        {
            TempData["name param"] = name;
            TempData["price param"] = price.ToString();
            return RedirectToPage("FormResults");
        }
    }
}
