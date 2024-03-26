using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BellaVitaPizzeria.Infrastructure.Data.Configuration
{
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            var data = new SeedData();

            builder.HasKey(x => new { x.ProductId, x.UserId });
            builder.HasOne(x=>x.Product).WithMany(x=>x.Ratings).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Rating[] { data.FiveStarRating, data.ThreeStarRating });
        }
    }
}
