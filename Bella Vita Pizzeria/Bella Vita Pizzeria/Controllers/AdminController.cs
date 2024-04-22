using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly RoleManager<IdentityRole> roleManager;

        public AdminController(
            IAdminService _adminService,
            RoleManager<IdentityRole> _roleManager)
        {
            adminService = _adminService;
            roleManager = _roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var model = await adminService.GetAllUsersAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            var model = new RoleModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModel model) 
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest();
            }

            if (await roleManager.RoleExistsAsync(model.Name) == false) 
            {
                var role = new IdentityRole() 
                {
                    Name = model.Name,
                };

                await roleManager.CreateAsync(role);
            }

            return RedirectToAction(nameof(AllRoles));
        }
    }
}
