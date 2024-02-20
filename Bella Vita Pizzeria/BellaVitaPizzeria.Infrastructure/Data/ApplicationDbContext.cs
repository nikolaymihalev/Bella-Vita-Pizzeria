using BellaVitaPizzeria.Infrastructure.Data.Configuration;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Bella_Vita_Pizzeria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductBuyer> ProductsBuyers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductBuyer>().HasKey(x => new { x.ProductId, x.BuyerId });
            builder.Entity<ProductBuyer>().HasOne(x => x.Product).WithMany(x => x.ProductsBuyers).OnDelete(DeleteBehavior.Restrict);            

            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
