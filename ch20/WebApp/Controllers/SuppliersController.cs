﻿// Listing 20.4 Related data in the SuppliersController.cs file in the Controllers folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private DataContext context;

        public SuppliersController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public async Task<Supplier?> GetSupplier(long id)
        {
            return await context.Suppliers
                .Include(s => s.Products)
                .FirstAsync(s => s.SupplierId == id);
        }
    }
}
