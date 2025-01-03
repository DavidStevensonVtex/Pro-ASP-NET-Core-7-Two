﻿// Listing 29.27 Adding parameters in the ValidationController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidationController : Controller
    {
        private DataContext dataContext;
        public ValidationController(DataContext context)
        {
            dataContext = context;
        }

        [HttpGet("categorykey")]
        public bool CategoryKey(string categoryId, [FromQuery] KeyTarget target)
        {
            long keyVal;
            return long.TryParse(categoryId ?? target.CategoryId, out keyVal) &&
                dataContext.Categories.Find(keyVal) != null;
        }

        [HttpGet("supplierkey")]
        public bool SupplierKey(string supplierId, [FromQuery] KeyTarget target)
        {
            long keyVal;
            return long.TryParse(supplierId ?? target.SupplierId, out keyVal) &&
                dataContext.Suppliers.Find(keyVal) != null;
        }
    }

    [Bind(Prefix = "Product")]
    public class KeyTarget
    {
        public string? CategoryId { get; set; }
        public string? SupplierId { get; set; }
    }
}
