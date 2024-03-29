using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface IFavoriteProductService
    {
        Task<IEnumerable<FavoriteProductInfoModel>> GetAllFavoriteProductsAsync();
        Task<IEnumerable<FavoriteProductInfoModel>> GetAllUserFavoriteProductsAsync(string userId);
        Task AddAsync(FavoriteProductInfoModel model);
        Task RemoveAsync(int productId, string userId);
    }
}
