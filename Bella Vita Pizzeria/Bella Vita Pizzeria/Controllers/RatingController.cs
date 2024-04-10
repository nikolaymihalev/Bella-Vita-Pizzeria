using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class RatingController : BaseController
    {
        private readonly IRatingService ratingService;
        private readonly IProductService productService;

        public RatingController(
            IRatingService _ratingService, 
            IProductService _productService)
        {
            ratingService = _ratingService;
            productService = _productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllRatings(int productId)
        {
            var product = await productService.GetByIdAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            var model = await ratingService.GetAllRatingsAboutProductAsync(productId);

            if (model.Count() == 0)
            {
                return RedirectToAction("Details", "Product", new { id = productId });
            }

            model.All(x => x.ProductTitle == product.Title);

            return View(model);
        }
    }
}
