using BellaVitaPizzeria.Core.Contracts;
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
    }
}
