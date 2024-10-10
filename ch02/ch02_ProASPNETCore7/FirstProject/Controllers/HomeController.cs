// Listing 2.7 Rendering a view in the HomeController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
    }
}
