﻿// Listing 18.7 The contents of the Product.cs file in the Models folder

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public required string Name { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public long CategoryId {  get ; set; }
        public Category? Category {  get; set; }

        public long SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
