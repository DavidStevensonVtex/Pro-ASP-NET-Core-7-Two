﻿// Listing 28.27 Removing an attribute in the Product.cs file in the Models folder

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public required string Name { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        //[BindNever]
        public decimal Price { get; set; }

        public long CategoryId {  get ; set; }
        public Category? Category {  get; set; }

        public long SupplierId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Supplier? Supplier { get; set; }
    }
}
