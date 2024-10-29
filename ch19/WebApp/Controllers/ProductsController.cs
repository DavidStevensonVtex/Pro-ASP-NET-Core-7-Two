//Listing 19.6 The contents of the ProductsController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase    
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return new Product[]
            {
                new Product() { Name = "Product #1" },
                new Product() { Name = "Product #2" }
            };
        }

        [HttpGet("{id}")]
        public Product GetProduct()
        {
            return new Product() { ProductId = 1, Name = "Test Product" };
        }
    }
}
