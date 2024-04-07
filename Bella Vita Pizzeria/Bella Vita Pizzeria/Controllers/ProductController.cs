using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllProducts() 
        {
            var model = await productService.GetProductsForPageAsync();

            return View(model);
        }
    }
}
