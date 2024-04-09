using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class FavoriteProductController : BaseController
    {
        private readonly IFavoriteProductService favoriteProductService;

        public FavoriteProductController(IFavoriteProductService _favoriteProductService)
        {
            favoriteProductService = _favoriteProductService;
        }
    }
}
