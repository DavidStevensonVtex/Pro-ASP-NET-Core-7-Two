// Listing 9.13 The OrderController.cs file in the SportsStore/Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
