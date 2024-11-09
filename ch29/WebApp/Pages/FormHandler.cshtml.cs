// Listing 28.18b Specifying a model binding prefix in the FormHandler.cshtml.cs file in the Pages folder

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

        [BindProperty(Name = "Product.Category")]
        public Category Category { get; set; } = new() { Name = string.Empty };

        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstAsync(p => p.ProductId == id);
        }

        public IActionResult OnPost()
        {
            TempData["product"] =
                System.Text.Json.JsonSerializer.Serialize(Product);
            TempData["category"] = 
                System.Text.Json.JsonSerializer.Serialize(Category);
            return RedirectToPage("FormResults");
        }
    }
}
