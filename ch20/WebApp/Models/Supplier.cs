// Listing 18.6 The contents of the Supplier.cs file in the Models folder

namespace WebApp.Models
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        public required string Name { get; set; }
        public required string City { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
