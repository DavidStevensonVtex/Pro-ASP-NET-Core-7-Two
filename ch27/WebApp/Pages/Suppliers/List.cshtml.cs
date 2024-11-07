// Listing 23.5 The contents of the List.cshtml.cs file in the Pages/Suppliers folder 

namespace WebApp.Pages.Suppliers
{
    public partial class ListModel : PageModel
    {
        private DataContext context;

        public IEnumerable<string> Suppliers { get; set; } = Enumerable.Empty<string>();

        public ListModel(DataContext ctx)
        {
            context = ctx;
        }

        public void OnGet()
        {
            Suppliers = context.Suppliers.Select(s => s.Name);
        }
    }
}
