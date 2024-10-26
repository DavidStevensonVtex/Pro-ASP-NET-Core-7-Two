// Listing 10.12 Adding methods in the IStoreRepository.cs file in the SportsStore/Models folder

namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get;}
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
