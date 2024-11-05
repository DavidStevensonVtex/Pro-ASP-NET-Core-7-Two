// Listing 25.24 Changing a property type in the Editor.cshtml.cs file in the Pages folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Pages
{
    public class EditorModel : PageModel
    {
        private DataContext context;

        public Product Product { get; set; } =
            new() { Name = string.Empty };

        public EditorModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task OnGetAsync(long id)
        {
            Product = await context.Products.FindAsync(id) ?? 
                new() { Name = string.Empty };
        }

        public async Task<IActionResult> OnPostAsync(long id, decimal price)
        {
            Product? p = await context.Products.FindAsync(id);
            if (p != null)
            {
                p.Price = price;
            }
            await context.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
