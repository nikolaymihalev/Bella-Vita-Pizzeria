using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync();
        Task AddAsync(ProductFormModel model);
        Task EditAsync(ProductFormModel model);
        Task<ProductInfoModel> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
