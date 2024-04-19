using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class UserController : BaseController
    {
        private readonly IProductService productService;

        public UserController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> AddToCart(int productId, string size) 
        {
            var product = await productService.GetByIdAsync(productId);

            if (product == null)
            {
                return BadRequest();
            }

            double price = 0;

            if (size == product.MinimumSize) 
            {
                price = product.MinimumPrice;
            }
            else if (size == product.MiddleSize)
            {
                price = product.MiddlePrice;
            }
            else if (size == product.MaxmimumSize)
            {
                price = product.MaximumPrice;
            }


            var model = new PurchaseModel(0,
                product.Title,
                size,
                product.Image,
                1,
                price,
                User.Id());

            try
            {
                await productService.AddToCartAsync(model);

                return RedirectToAction(nameof(Cart));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            var model = await productService.GetPurchasesAsync(User.Id());

            return View(model);
        }
    }
}
