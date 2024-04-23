using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Core.Models.Cart;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class UserController : BaseController
    {
        private readonly IProductService productService;
        private readonly ICartService cartService;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(
            IProductService _productService,
            ICartService _cartService,
            UserManager<IdentityUser> _userManager)
        {
            productService = _productService;
            cartService = _cartService;
            userManager = _userManager;
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
                await cartService.AddToCartAsync(model);

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
            var model = await cartService.GetPurchasesAsync(User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangeQuantity(int id,string operation) 
        {
            await cartService.ChangeQuantityAsync(id, operation);

            return RedirectToAction(nameof(Cart));
        }

        [HttpGet]
        public async Task<IActionResult> DeletePurchase(int id) 
        {
            await cartService.DeletePurchaseAsync(id, User.Id());

            return RedirectToAction(nameof(Cart));
        }

        [HttpGet]
        public async Task<IActionResult> Checkout() 
        {
            var model = new OrderFormModel();

            model.Email = userManager.FindByIdAsync(User.Id()).Result.Email;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(OrderFormModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            model.UserId = User.Id();

            await cartService.AddOrderAsync(model);

            return RedirectToAction(nameof(Cart));
        }

        [HttpGet]
        public async Task<IActionResult> CompleteOrder(int id) 
        {
            await cartService.DeleteOrderAsync(id);

            return RedirectToAction("Index","Home");
        }
    }
}
