using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models;

namespace BellaVitaPizzeria.Core.Services
{
    public class RatingService : IRatingService
    {
        public Task AddAsync(RatingFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int productId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(RatingFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RatingInfoModel>> GetAllRatingsAboutProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetAverageRatingAboutProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
