﻿// Listing 5.57 Using the new method in the HomeController.cs file in the Controllers folder

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            List<string> output = new List<string>();
            foreach (long? len in await MyAsyncMethods.GetPageLengths(
                output,
                "manning.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {len}");
            }

            return View(output);
        }
    }
}
