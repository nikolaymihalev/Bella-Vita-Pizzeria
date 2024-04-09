using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class FavoriteProductController : BaseController
    {
        private readonly IFavoriteProductService favoriteProductService;

        public FavoriteProductController(IFavoriteProductService _favoriteProductService)
        {
            favoriteProductService = _favoriteProductService;
        }

        [HttpGet]
        public async Task<IActionResult> MyFavoriteProducts()
        {
            var model = await favoriteProductService.GetAllUserFavoriteProductsAsync(User.Id());

            return View(model);
        }
    }
}
