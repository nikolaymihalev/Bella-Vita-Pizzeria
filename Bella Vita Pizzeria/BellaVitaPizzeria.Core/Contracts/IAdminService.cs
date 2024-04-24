using BellaVitaPizzeria.Core.Models.Cart;
using BellaVitaPizzeria.Core.Models.User;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface IAdminService
    {
        Task<IEnumerable<UserModel>> GetAllUsersAsync();
        Task<IEnumerable<RoleModel>> GetAllRolesAsync();
        Task<OrdersStatisticModel> GetStatisticsAsync();
        Task<int> GetUserOrdersCountAsync(string userId);
        Task<bool> UserExistsAsync(string userId);
    }
}
