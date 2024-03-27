namespace BellaVitaPizzeria.Infrastructure.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllReadonly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        Task DeleteAsync<T>(object id) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(IEnumerable<T> entitites) where T : class;
        Task<int> SaveChangesAsync();
    }
}
