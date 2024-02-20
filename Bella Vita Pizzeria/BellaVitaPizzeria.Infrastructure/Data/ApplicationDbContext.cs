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

            builder.Entity<Product>().Property(e => e.Price).HasPrecision(18, 8);

            builder.Entity<Category>()
                .HasData(new Category()
                {
                    Id = 1,
                    Name = "Pizza"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Pasta"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Soup"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Grill"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Dessert"
                });

            base.OnModelCreating(builder);
        }
    }
}
