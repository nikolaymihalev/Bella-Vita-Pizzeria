using Bella_Vita_Pizzeria.Data;
using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Infrastructure.Data.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BellaVitaPizzeria.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger logger;

        public ProductService(
            ApplicationDbContext _context, 
            ILogger _logger)
        {
            context = _context;
            logger = _logger;
        }

        public async Task AddAsync(ProductDto product)
        {
            var entity = new Product()
            {
                Title = product.Title,
                Ingredients = product.Ingredients,
                CategoryId = product.CategoryId,
                Weight = product.Weight,
                Price = product.Price,
                PriceForPizzaBig = product.PriceForPizzaBig,
                PriceForPizzaFamily = product.PriceForPizzaFamily,
                ImageUrl = product.ImageUrl,
            };

            try
            {
                await context.Products.AddAsync(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ProductService.AddAsync");
                throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            return await context.Products
                .AsNoTracking()
                .Select(x => new ProductDto()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Ingredients = x.Ingredients,
                    CategoryId = x.CategoryId,
                    Weight = x.Weight,
                    Price = x.Price,
                    PriceForPizzaBig = x.PriceForPizzaBig,
                    PriceForPizzaFamily = x.PriceForPizzaFamily,
                    ImageUrl = x.ImageUrl,
                    CategoryDto = new CategoryDto()
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name,
                    }
                }).ToListAsync();
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            return await context.Products
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => new ProductDto()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Ingredients = x.Ingredients,
                    CategoryId = x.CategoryId,
                    Weight = x.Weight,
                    Price = x.Price,
                    PriceForPizzaBig = x.PriceForPizzaBig,
                    PriceForPizzaFamily = x.PriceForPizzaFamily,
                    ImageUrl = x.ImageUrl,
                    CategoryDto = new CategoryDto()
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name,
                    }
                }).FirstOrDefaultAsync();
        }
    }
}
