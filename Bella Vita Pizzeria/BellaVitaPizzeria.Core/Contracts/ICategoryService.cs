using BellaVitaPizzeria.Core.Models.Category;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryInfoModel>> GetAllCategoriesAsync();
        Task AddAsync(CategoryFormModel model);
        Task EditAsync(CategoryFormModel model);
        Task DeleteAsync(int id);
        Task<CategoryInfoModel> GetByIdAsync(int id);
        Task<CategoryInfoModel> GetByNameAsync(string name);
    }
}
