using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface ICartService
    {
        Task AddToCartAsync(PurchaseModel model);
        Task<IEnumerable<PurchaseModel>> GetPurchasesAsync(string userId);
        Task ChangeQuantityAsync(int id, string operation);
        Task DeletePurchaseAsync(int id, string userId);
        Task AddOrderAsync(OrderFormModel model);
        Task DeleteOrderAsync(int id);
    }
}
