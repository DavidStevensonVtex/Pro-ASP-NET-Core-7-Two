﻿// Listing 31.15 Adding the delete method in the ViewModelFactory.cs file in the Models folder

namespace WebApp.Models
{
    public static class ViewModelFactory
    {
        public static ProductViewModel Details(Product p)
        {
            return new ProductViewModel
            {
                Product = p,
                Action = "Details",
                ReadOnly = true,
                Theme = "info",
                ShowAction = false,
                Categories = p == null || p.Category == null ?
                    Enumerable.Empty<Category>() :
                    new List<Category>() { p.Category },
                Suppliers = p == null || p.Supplier == null ?
                    Enumerable.Empty<Supplier>() :
                    new List<Supplier>() { p.Supplier },
            };
        }

        public static ProductViewModel Create(
            Product p,
            IEnumerable<Category> categories,
            IEnumerable<Supplier> suppliers)
        {
            return new ProductViewModel
            {
                Product = p,
                Categories = categories,
                Suppliers = suppliers,
            };
        }

        public static ProductViewModel Edit(
            Product p,
            IEnumerable<Category> categories,
            IEnumerable<Supplier> suppliers)
        {
            return new ProductViewModel
            {
                Product = p,
                Categories = categories,
                Suppliers = suppliers,
                Theme = "warning",
                Action = "Edit"
            };
        }

        public static ProductViewModel Delete(
            Product p,
            IEnumerable<Category> categories,
            IEnumerable<Supplier> suppliers)
        {
            return new ProductViewModel
            {
                Product = p,
                Action = "Delete",
                ReadOnly = true,
                Theme = "danger",
                Categories = p == null || p.Category == null ?
                    Enumerable.Empty<Category>() :
                    new List<Category>() { p.Category },
                Suppliers = p == null || p.Supplier == null ?
                    Enumerable.Empty<Supplier>() :
                    new List<Supplier>() { p.Supplier },
            };
        }

    }
}
