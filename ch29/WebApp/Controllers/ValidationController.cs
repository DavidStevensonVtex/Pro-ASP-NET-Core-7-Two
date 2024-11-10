// Listing 29.25 The contents of the ValidationController.cs file in the Controllers folder

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
        public bool CategoryKey(string categoryId)
        {
            long keyVal;
            return long.TryParse(categoryId, out keyVal) &&
                dataContext.Categories.Find(keyVal) != null;
        }

        [HttpGet("supplierkey")]
        public bool SupplierKey(string supplierId)
        {
            long keyVal;
            return long.TryParse(supplierId, out keyVal) &&
                dataContext.Suppliers.Find(keyVal) != null;
        }
    }
}
