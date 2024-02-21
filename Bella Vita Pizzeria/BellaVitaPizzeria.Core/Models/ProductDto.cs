using BellaVitaPizzeria.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.ProductTitleMaxLength, 
            MinimumLength = ValidationConstants.ProductTitleMinLength)]
        public required string Title { get; set; }

        [Required]
        [StringLength(ValidationConstants.ProductIngredientsMaxLength,
            MinimumLength = ValidationConstants.ProductIngredientsMinLength)]
        public required string Ingredients { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public int Weight { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal PriceForPizzaBig { get; set; }

        public decimal PriceForPizzaFamily { get; set; }

        [Required]
        public required string ImageUrl { get; set; }
    }
}
