// Listing 7.9 The contents of the HomeController.cs file in the SportsStore/Controllers folder

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
