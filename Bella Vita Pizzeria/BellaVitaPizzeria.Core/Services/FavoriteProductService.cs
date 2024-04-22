using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Core.Models.Product;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BellaVitaPizzeria.Core.Services
{
    public class FavoriteProductService : IFavoriteProductService
    {
        private readonly IRepository repository;

        public FavoriteProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(FavoriteProductInfoModel model)
        {
            var entity = new FavoriteProduct()
            {
                UserId = model.UserId,
                ProductId = model.ProductId,
            };

            try
            {
                await repository.AddAsync<FavoriteProduct>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }
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

        public async Task<IEnumerable<FavoriteProductInfoModel>> GetAllUserFavoriteProductsAsync(string userId)
        {
            return await repository.AllReadonly<FavoriteProduct>()
                .Where(x=>x.UserId == userId)
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

        public async Task RemoveAsync(int productId, string userId)
        {
            try
            {
                repository.Delete(new FavoriteProduct() { ProductId = productId, UserId = userId });
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }
        }
    }
}
