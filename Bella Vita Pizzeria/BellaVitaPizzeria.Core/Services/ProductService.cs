using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BellaVitaPizzeria.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task AddAsync(ProductFormModel model)
        {
            var product = new Product()
            {
                Title = model.Title,
                Description = model.Description,
                Image = model.Image,
                CategoryId = model.CategoryId,
                MiddlePrice = model.MiddlePrice,
                MinimumPrice = model.MinimumPrice,
                MaximumPrice = model.MaximumPrice,
                MinimumSize = model.MinimumSize,
                MiddleSize = model.MiddleSize,
                MaxmimumSize = model.MaximumSize,
            };

            try
            {
                await repository.AddAsync<Product>(product);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }
        }

        public async Task AddToCartAsync(PurchaseModel model)
        {
            var cart = repository.AllReadonly<Cart>()
                .FirstOrDefault(x => x.UserId == model.UserId && x.Purchase.Title == model.Title && x.Purchase.Size == model.Size);

            if (cart != null)
            {
                var purchase = await repository.GetByIdAsync<Purchase>(cart.PurchaseId);
                purchase.Quantity++;
            }
            else 
            {
                var purchase = new Purchase()
                {
                    Title = model.Title,
                    Size = model.Size,
                    Quantity = 1,
                    Image = Convert.FromBase64String(model.Image),
                    UnitPrice = model.UnitPrice,
                };
                await repository.AddAsync<Purchase>(purchase);
                await repository.AddAsync<Cart>(new Cart() { UserId = model.UserId, Purchase = purchase });
            }

            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await repository.GetByIdAsync<Product>(id);

            if (product != null) 
            {
                await repository.DeleteAsync<Product>(id);

                await repository.SaveChangesAsync();
            }

            throw new ArgumentException(ErrorMessagesConstants.OperationFailedErrorMessage);
        }

        public async Task EditAsync(ProductFormModel model)
        {
            var product = await repository.GetByIdAsync<Product>(model.Id);

            if (product != null) 
            {
                
                product.Id = model.Id;
                product.Title = model.Title;
                product.Description = model.Description;
                product.Image = model.Image;
                product.CategoryId = model.CategoryId;
                product.MiddlePrice = model.MiddlePrice;
                product.MinimumPrice = model.MinimumPrice;
                product.MaximumPrice = model.MaximumPrice;
                product.MinimumSize = model.MinimumSize;
                product.MiddleSize = model.MiddleSize;
                product.MaxmimumSize = model.MaximumSize;

                await repository.SaveChangesAsync();
            }

            throw new ArgumentException(string.Format(ErrorMessagesConstants.InvalidModelErrorMessage, "product"));
        }

        public async Task<IEnumerable<ProductInfoModel>> GetAllProductsAsync()
        {
            return await repository.AllReadonly<Product>()
                .Select(x => new ProductInfoModel(
                    x.Id,
                    x.Title,
                    x.Description ?? string.Empty,
                    Convert.ToBase64String(x.Image),
                    x.CategoryId,
                    x.Category.Name,
                    x.MinimumPrice,
                    x.MiddlePrice ?? 0,
                    x.MaximumPrice ?? 0,
                    x.MinimumSize,
                    x.MiddleSize ?? string.Empty,
                    x.MaxmimumSize ?? string.Empty))
                .ToListAsync();
        }

        public async Task<ProductInfoModel> GetByIdAsync(int id)
        {
            Product? entity = await repository.GetByIdAsync<Product>(id);
            var category = await repository.AllReadonly<Category>().FirstAsync(x=>x.Id==entity.CategoryId);

            if (entity != null) 
            {
                return new ProductInfoModel(
                    entity.Id,
                    entity.Title,
                    entity.Description ?? string.Empty,
                    Convert.ToBase64String(entity.Image),
                    entity.CategoryId,
                    category.Name,
                    entity.MinimumPrice,
                    entity.MiddlePrice ?? 0,
                    entity.MaximumPrice ?? 0,
                    entity.MinimumSize,
                    entity.MiddleSize ?? string.Empty,
                    entity.MaxmimumSize ?? string.Empty);
            }

            throw new ArgumentException(string.Format(ErrorMessagesConstants.DoesntExistErrorMessage, "product"));
        }

        public async Task<ProductQueryModel> GetProductsForPageAsync(string? category = null, int currentPage = 1)
        {
            var model = new ProductQueryModel();

            model.Products = await GetAllProductsAsync();

            int formula = (currentPage - 1) * ValidationConstants.MaxProductsPerPage;

            if (currentPage <= 1)
            {
                formula = 0;
            }

            if (category != null)
            {
                if (category.ToLower() != "all")
                {
                    model.Products = model.Products
                        .Where(x => x.CategoryName.ToLower() == category.ToLower())
                        .ToList();
                    model.Category = category;
                }
            }

            model.PagesCount = Math.Ceiling((model.Products.Count() / Convert.ToDouble(ValidationConstants.MaxProductsPerPage)));

            model.Products = model.Products
                .Skip(formula)
                .Take(ValidationConstants.MaxProductsPerPage);

            model.CurrentPage = currentPage;

            return model;
        }

        public async Task<IEnumerable<PurchaseModel>> GetPurchasesAsync(string userId)
        {
            return await repository.AllReadonly<Cart>()
                .Where(x => x.UserId == userId)
                .Select(x => new PurchaseModel(
                    x.Purchase.Id,
                    x.Purchase.Title,
                    x.Purchase.Size,
                    Convert.ToBase64String(x.Purchase.Image),
                    x.Purchase.Quantity,
                    x.Purchase.UnitPrice,
                    x.UserId))
                .ToListAsync();                
        }
    }
}
