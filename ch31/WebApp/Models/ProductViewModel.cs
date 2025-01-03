﻿// Listing 31.7 The contents of the ProductViewModel.cs file in the Models folder

namespace WebApp.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; } = new() { Name = string.Empty };

        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
        public IEnumerable<Category> Categories { get; set; }
            = Enumerable.Empty<Category>();

        public IEnumerable<Supplier> Suppliers { get; set; } 
            = Enumerable.Empty<Supplier>();
    }
}
