using BellaVitaPizzeria.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Product")]
    public class Product
    {
        [Comment("Product identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product title")]
        [Required]
        [MaxLength(ValidationConstants.ProductTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Comment("Product description")]
        public string? Description { get; set; }

        [Comment("Product image")]
        [Required]
        public byte[] Image { get; set; } = new byte[128];

        [Comment("Category identifier")]
        [Required]
        public int CategoryId { get; set; }

        [Comment("Product price for minimum weight")]
        [Required]
        public double MinimumPrice { get; set; }

        [Comment("Product price for middle weight")]
        public double? MiddlePrice { get; set; }

        [Comment("Product price for maximum weight")]
        public double? MaximumPrice { get; set; }

        [Comment("Product minimum weight")]
        [Required]
        [MaxLength(ValidationConstants.ProductWeightMaxLength)]
        public string MinimumWeight { get; set; } = string.Empty;

        [Comment("Product middle weight")]
        public string? MiddleWeight { get; set; }

        [Comment("Product maximum weight")]
        public string? MaxmimumWeight { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public IList<FavoriteProduct> FavoriteProducts { get; set; } = new List<FavoriteProduct>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
