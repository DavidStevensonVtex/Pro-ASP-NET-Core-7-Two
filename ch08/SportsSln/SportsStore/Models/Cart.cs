﻿// Listing 8.22 The contents of the Cart.cs file in the SportsStore/Models folder

namespace SportsStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }

        public void AddItem ( Product product, int quantity)
        {
            CartLine? line = Lines.FirstOrDefault(p => p.Product.ProductID == product.ProductID);

            if ( line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            } 
            else
            {
                line.Quantity = quantity;
            }
        }

        public void RemoveLine (Product product)
        {
            Lines.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Product.Price * e.Quantity);

        public void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
