using Bella_Vita_Pizzeria.Models;
using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService categoryService;

        public HomeController(
            ILogger<HomeController> logger,
            ICategoryService _categoryService)
        {
            _logger = logger;
            categoryService = _categoryService;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("AllUsers", "Admin");
            }
            ViewBag.Categories = await categoryService.GetAllCategoriesAsync();
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
