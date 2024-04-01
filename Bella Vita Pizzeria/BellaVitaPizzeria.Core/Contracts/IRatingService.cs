using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Contracts
{
    public interface IRatingService
    {
        Task AddAsync(RatingFormModel model);
        Task EditAsync(RatingFormModel model);
        Task DeleteAsync(int productId, string userId);
        Task<double> GetAverageRatingAboutProductAsync(int productId);
        Task<IEnumerable<RatingInfoModel>> GetAllRatingsAboutProductAsync(int productId);
    }
}
