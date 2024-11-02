// Listing 23.26b The contents of the Data.cshtml.cs file in the Pages folder

namespace WebApp.Pages
{
    public class DataPageModel : PageModel
    {
        private DataContext context;

        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();

        public DataPageModel(DataContext ctx)
        {
            context = ctx;
        }

        public void OnGet()
        {
            Categories = context.Categories;
        }
    }
}
