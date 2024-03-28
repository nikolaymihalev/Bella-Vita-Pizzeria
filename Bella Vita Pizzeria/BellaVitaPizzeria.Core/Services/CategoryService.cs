using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BellaVitaPizzeria.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task AddAsync(CategoryFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(CategoryFormModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryInfoModel>> GetAllCategoriesAsync()
        {
            return await repository.AllReadonly<Category>()
                .Select(x => new CategoryInfoModel(
                    x.Id,
                    x.Name))
                .ToListAsync();
        }

        public async Task<CategoryInfoModel> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Category>(id);

            if (entity != null) 
            {
                return new CategoryInfoModel(
                    entity.Id, 
                    entity.Name);                
            }

            throw new ArgumentException(string.Format(ErrorMessagesConstants.DoesntExistErrorMessage, "category"));
        }
    }
}
