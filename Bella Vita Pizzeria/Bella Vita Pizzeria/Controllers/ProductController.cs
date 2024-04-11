using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using BellaVitaPizzeria.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;        
        private readonly IFavoriteProductService favoriteProductService;        
        private readonly IRatingService ratingService;        

        public ProductController(
            IProductService _productService, 
            ICategoryService _categoryService,
            IFavoriteProductService _favoriteProductService,
            IRatingService _ratingService)
        {
            productService = _productService;
            categoryService = _categoryService;
            favoriteProductService = _favoriteProductService;
            ratingService = _ratingService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllProducts() 
        {
            var model = await productService.GetProductsForPageAsync();

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormModel()
            {
                Categories = await categoryService.GetAllCategoriesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                model.Categories = await categoryService.GetAllCategoriesAsync();
                return View(model);
            }

            if (model.ImageFile == null)
            {
                model.Categories = await categoryService.GetAllCategoriesAsync();
                return View(model);
            }

            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    model.ImageFile.CopyTo(memoryStream);
                    byte[] imageBytes = memoryStream.ToArray();

                    model.Image = imageBytes;

                    await productService.AddAsync(model);
                }
                return RedirectToAction(nameof(AllProducts));
            }

            model.Categories = await categoryService.GetAllCategoriesAsync();
            return View(model);
        }
    }
}
