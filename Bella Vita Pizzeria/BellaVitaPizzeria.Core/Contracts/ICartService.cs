using BellaVitaPizzeria.Core.Models.Cart;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface ICartService
    {
        Task AddToCartAsync(PurchaseModel model);
        Task<IEnumerable<PurchaseModel>> GetPurchasesAsync(string userId);
        Task ChangeQuantityAsync(int id, string operation);
        Task DeletePurchaseAsync(int id, string userId);
        Task AddOrderAsync(OrderFormModel model);
        Task<IEnumerable<OrderFormModel>> GetOrdersAsync();
        Task CompleteOrderAsync(int id);
        Task DeleteOrderAsync(int id);
    }
}
