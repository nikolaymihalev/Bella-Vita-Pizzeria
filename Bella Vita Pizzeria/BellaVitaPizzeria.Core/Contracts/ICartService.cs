using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface ICartService
    {
        Task AddToCartAsync(PurchaseModel model);
        Task<IEnumerable<PurchaseModel>> GetPurchasesAsync(string userId);
    }
}
