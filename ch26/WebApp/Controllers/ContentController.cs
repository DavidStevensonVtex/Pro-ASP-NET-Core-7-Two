﻿// Listing 20.27 Removing XML action in the ContentController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

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
        [OutputCache(PolicyName = "30sec")]
        [Produces("application/json")]
        public string GetString() => $"{DateTime.Now.ToLongTimeString()} String response";

        [HttpGet("object/{format?}")]
        [FormatFilter]
        [Produces("application/json", "application/xml")]
        public async Task<ProductBindingTarget> GetObject()
        {
            Product p = await context.Products.FirstAsync();
            return new ProductBindingTarget()
            {
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
                SupplierId = p.SupplierId
            };
        }

        [HttpPost]
        [Consumes("application/json")]
        public string SaveProductJson(ProductBindingTarget product)
        {
            return $"JSON: {product.Name}";
        }

        //[HttpPost]
        //[Consumes("application/xml")]
        //public string SaveProductXml(ProductBindingTarget product)
        //{
        //    return $"XML: {product.Name}";
        //}
    }
}
