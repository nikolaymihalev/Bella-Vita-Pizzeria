using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models.Rating;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace BellaVitaPizzeria.Core.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository repository;

        public RatingService(
            IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(RatingFormModel model)
        {
            var entity = new Rating()
            {
                ProductId = model.ProductId,
                UserId = model.UserId,
                Value = model.Value,
            };

            try
            {
                await repository.AddAsync<Rating>(entity);
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }
        }

        public async Task DeleteAsync(int productId, string userId)
        {
            var entity = await repository.AllReadonly<Rating>()
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId);

            if (entity == null) 
            {
                throw new ArgumentException(ErrorMessagesConstants.OperationFailedErrorMessage);
            }

            repository.Delete(entity);

            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(RatingFormModel model)
        {
            var allRatings = repository.AllReadonly<Rating>();

            if (!allRatings.Any())
            {
                throw new ApplicationException(string.Format(ErrorMessagesConstants.InvalidModelErrorMessage, "rating"));
            }

            var rating = allRatings.FirstOrDefault(x => x.UserId == model.UserId && x.ProductId == model.ProductId);

            if (rating == null)
            {
                throw new ApplicationException(string.Format(ErrorMessagesConstants.InvalidModelErrorMessage, "rating"));
            }

            await DeleteAsync(model.ProductId, model.UserId);
            await AddAsync(model);

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<RatingInfoModel>> GetAllRatingsAboutProductAsync(int productId)
        {
            return await repository.AllReadonly<Rating>()
                .Where(x=> x.ProductId == productId)
                .Select(x => new RatingInfoModel(
                    x.ProductId,
                    x.Product.Title,
                    x.UserId,
                    x.User.UserName,
                    x.Value))
                .ToListAsync();
        }

        public async Task<double> GetAverageRatingAboutProductAsync(int productId)
        {
            return await repository.AllReadonly<Rating>()
                .Where(x => x.ProductId == productId)
                .AverageAsync(x => x.Value);
        }
    }
}
