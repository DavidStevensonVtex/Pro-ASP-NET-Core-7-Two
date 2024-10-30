// Listing 20.10 The contents of the ContentController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ContentController : ControllerBase
    {
        private DataContext context;
        
        public ContentController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("string")]
        public string GetString() => "This is a string response";

        [HttpGet("object")]
        public async Task<Product> GetObject()
        {
            return await context.Products.FirstAsync();
        }
    }
}
