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

        [Comment("Product price for minimum size")]
        [Required]
        public double MinimumPrice { get; set; }

        [Comment("Product price for middle size")]
        public double? MiddlePrice { get; set; }

        [Comment("Product price for maximum size")]
        public double? MaximumPrice { get; set; }

        [Comment("Product minimum size")]
        [Required]
        [MaxLength(ValidationConstants.ProductWeightMaxLength)]
        public string MinimumSize { get; set; } = string.Empty;

        [Comment("Product middle size")]
        public string? MiddleSize { get; set; }

        [Comment("Product maximum size")]
        public string? MaxmimumSize { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public IList<FavoriteProduct> FavoriteProducts { get; set; } = new List<FavoriteProduct>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
