using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BellaVitaPizzeria.Core.Services
{
    public class FavoriteProductService : IFavoriteProductService
    {
        private readonly IRepository repository;

        public FavoriteProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task AddAsync(FavoriteProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FavoriteProductInfoModel>> GetAllFavoriteProductsAsync()
        {
            return await repository.AllReadonly<FavoriteProduct>()
                .Select(x => new FavoriteProductInfoModel(
                    x.ProductId,
                    x.UserId,
                    new ProductInfoModel(
                        x.Product.Id,
                        x.Product.Title,
                        x.Product.Description ?? string.Empty,
                        Convert.ToBase64String(x.Product.Image),
                        x.Product.CategoryId,
                        x.Product.Category.Name,
                        x.Product.MinimumPrice,
                        x.Product.MiddlePrice ?? 0,
                        x.Product.MaximumPrice ?? 0,
                        x.Product.MinimumSize,
                        x.Product.MiddleSize ?? string.Empty,
                        x.Product.MaxmimumSize ?? string.Empty)))
                .ToListAsync();

        }

        public Task<IEnumerable<FavoriteProductInfoModel>> GetAllUserFavoriteProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int productId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
