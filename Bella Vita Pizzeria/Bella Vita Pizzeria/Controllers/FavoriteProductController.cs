using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class FavoriteProductController : BaseController
    {
        private readonly IFavoriteProductService favoriteProductService;
        private readonly IProductService productService;

        public FavoriteProductController(
            IFavoriteProductService _favoriteProductService, 
            IProductService _productService)
        {
            favoriteProductService = _favoriteProductService;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> MyFavoriteProducts()
        {
            var model = await favoriteProductService.GetAllUserFavoriteProductsAsync(User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddFavoriteProduct(int id)
        {
            var favoriteProducts = await favoriteProductService.GetAllFavoriteProductsAsync();

            if(favoriteProducts.Any(x=> x.ProductId == id && x.UserId==User.Id()))
            {
                return BadRequest();
            }

            var product = await productService.GetByIdAsync(id);

            if(product == null) 
            {
                return BadRequest();
            }

            await favoriteProductService.AddAsync(new FavoriteProductInfoModel
                (
                    id,
                    User.Id(),
                    product));

            return RedirectToAction("Details", "Product", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> RemoveFavoriteProduct(int id) 
        {
            var favoriteProducts = await favoriteProductService.GetAllFavoriteProductsAsync();

            var product = favoriteProducts.FirstOrDefault(x=> x.ProductId == id && x.UserId == User.Id());

            if (product == null) 
            {
                return BadRequest();
            }

            await favoriteProductService.RemoveAsync(id, User.Id());

            return RedirectToAction(nameof(MyFavoriteProducts));
        }
    }
}
