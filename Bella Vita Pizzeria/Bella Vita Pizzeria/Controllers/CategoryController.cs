using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> AllCategories() 
        {
            var model = await categoryService.GetAllCategoriesAsync();

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
    }
}
