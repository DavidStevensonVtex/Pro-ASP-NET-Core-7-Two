// Listing 27.8b The contents of the FromHandler.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    [IgnoreAntiforgeryToken]
    public class FormHandlerModel : PageModel
    {
        private DataContext context;

        public FormHandlerModel(DataContext dbContext)
        {
            context = dbContext;
        }

        public Product? Product { get; set; }

        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
        }

        public IActionResult OnPost()
        {
            foreach (string key in Request.Form.Keys
                .Where(k => !k.StartsWith("_")))
            {
                TempData[key] = string.Join(", ", (string?)Request.Form[key]);
            }

            return RedirectToPage("FormResults");
        }
    }
}
