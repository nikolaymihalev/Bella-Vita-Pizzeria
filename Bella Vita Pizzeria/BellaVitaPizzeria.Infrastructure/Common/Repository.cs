using Bella_Vita_Pizzeria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BellaVitaPizzeria.Infrastructure.Common
{
    public class Repository : IRepository
    {
        public DbContext Context { get; set; }

        private DbSet<T> DbSet<T>() where T : class 
        {
            return this.Context.Set<T>();
        }

        public Repository(ApplicationDbContext _context)
        {
            Context = _context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public IQueryable<T> AllReadonly<T>() where T : class
        {
            return DbSet<T>().AsQueryable().AsNoTracking();
        }

        public void Delete<T>(T entity) where T : class
        {
            EntityEntry entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DbSet<T>().Attach(entity);
            }

            entry.State = EntityState.Deleted;
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null) 
            {
                DbSet<T>().Remove(entity);
            }
        }

        public void DeleteRange<T>(IEnumerable<T> entitites) where T : class
        {
            DbSet<T>().RemoveRange(entitites);
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.Context.SaveChangesAsync();
        }
    }
}
