// Listing 9.17 The IOrderRepository.cs file in the SportsStore/Models folder

namespace SportsStore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
