﻿// Listing 18.5 The contents of the Category.cs file in the Models folder

namespace WebApp.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public required string Name { get; set; }
        public IEnumerable<Supplier>? Products { get; set; }
    }
}
