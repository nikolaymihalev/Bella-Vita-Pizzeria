using Bella_Vita_Pizzeria.Data;
using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Infrastructure.Data.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
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

        public Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
