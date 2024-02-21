using BellaVitaPizzeria.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task AddAsync(ProductDto product);
        Task<ProductDto?> GetByIdAsync(int id);
        Task EditAsync(ProductDto product);
        Task DeleteAsync(int id);
    }
}
