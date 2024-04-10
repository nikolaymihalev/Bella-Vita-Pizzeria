using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        [HttpGet]
        public async Task<IActionResult> Add(int productId)
        {
            var product = await productService.GetByIdAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            var model = new RatingFormModel()
            {
                ProductId = productId,
                Value = 0,
                UserId = User.Id()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RatingFormModel model, int productId)
        {
            model.UserId = User.Id();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product = await productService.GetByIdAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            var products = await ratingService.GetAllRatingsAboutProductAsync(productId);

            if (products.Any(x => x.UserId == User.Id()))
            {
                return BadRequest();
            }

            await ratingService.AddAsync(model);

            return RedirectToAction(nameof(GetAllRatings), new { productId });
        }
    }
}
