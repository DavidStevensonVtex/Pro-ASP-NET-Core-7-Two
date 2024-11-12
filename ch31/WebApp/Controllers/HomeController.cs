// Listing 30.43 Setting filter order in the HomeController.cs file in the Controllers folder

namespace WebApp.Controllers
{
    [Message("This is the controller-scoped filter", Order = 10)]
    public class HomeController : Controller
    {
        [Message("This is the first action-scoped filter", Order = 1)]
        [Message("This is the second action-scoped filter", Order = -1)]
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }
    }
}