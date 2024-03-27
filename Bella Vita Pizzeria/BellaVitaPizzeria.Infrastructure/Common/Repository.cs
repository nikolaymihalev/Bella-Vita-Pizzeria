
namespace BellaVitaPizzeria.Infrastructure.Common
{
    public class Repository : IRepository
    {
        public Task AddAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> AllReadonly<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public void DeleteRange<T>(IEnumerable<T> entitites) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
