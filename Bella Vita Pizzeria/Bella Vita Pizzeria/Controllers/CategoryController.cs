using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        public CategoryController(
            ICategoryService _categoryService, 
            IProductService _productService)
        {
            categoryService = _categoryService;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> AllCategories() 
        {
            var model = await categoryService.GetAllCategoriesAsync();

            foreach (var item in model) 
            {
                item.IsInUse = await IsCategoryInUse(item.Name);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            var model = new CategoryFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryFormModel model) 
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            await categoryService.AddAsync(model);

            return RedirectToAction(nameof(AllCategories));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await categoryService.GetByIdAsync(id);

            if (category == null)
            {
                return BadRequest();
            }

            var model = new CategoryFormModel()
            {
                Id = category.Id,
                Name = category.Name,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryFormModel model, int id) 
        {
            var category = await categoryService.GetByIdAsync(id);

            if (category == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            await categoryService.EditAsync(model);

            return RedirectToAction(nameof(AllCategories));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await categoryService.GetByIdAsync(id);
            if(category == null)
            {
                return BadRequest();
            }

            bool isInUse = await IsCategoryInUse(category.Name);

            if (isInUse)
            {
                return BadRequest();
            }

            await categoryService.DeleteAsync(id);
            return RedirectToAction(nameof(AllCategories));

        }
        private async Task<bool> IsCategoryInUse(string name) 
        {
            var products = await productService.GetAllProductsAsync();
            var recipes = products.Where(x => x.CategoryName == name);

            if (recipes.Any())
                return true;

            return false;
        }
    }
}
