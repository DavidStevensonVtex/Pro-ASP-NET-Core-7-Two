﻿// Listing 10.13 Implementing methods in the EFStoreRepository.cs file in the SportsStore/Models folder

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteProduct(Product p)
        {
            context.Remove(p);
        }

        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }
    }
}
