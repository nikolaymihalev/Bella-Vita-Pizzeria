using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models.Cart;
using BellaVitaPizzeria.Core.Models.User;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BellaVitaPizzeria.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<RoleModel>> GetAllRolesAsync()
        {
            return await repository.AllReadonly<IdentityRole>()
                .Select(x => new RoleModel() {
                   Id = x.Id,
                   Name = x.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<UserModel>> GetAllUsersAsync()
        {
            return await repository.AllReadonly<IdentityUser>()
                .Select(x=> new UserModel(
                    x.Id,
                    x.UserName))
                .ToListAsync();
        }

        public async Task<bool> UserExistsAsync(string userId)
        {
            return await repository.AllReadonly<IdentityUser>().AnyAsync(x => x.Id == userId);
        }
    }
}
