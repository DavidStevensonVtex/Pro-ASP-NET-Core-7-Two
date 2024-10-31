// Listing 21.5 The contents of the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;

        public HomeController (DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            return View(await context.Products.FindAsync(id));
        }
    }
}
