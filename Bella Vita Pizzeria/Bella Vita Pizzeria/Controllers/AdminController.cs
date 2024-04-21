using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IProductService productService;

        public AdminController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
