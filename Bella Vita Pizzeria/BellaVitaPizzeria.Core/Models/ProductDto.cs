using BellaVitaPizzeria.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductTitleMaxLength, 
            MinimumLength = ValidationConstants.ProductTitleMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public required string Title { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductIngredientsMaxLength,
            MinimumLength = ValidationConstants.ProductIngredientsMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public required string Ingredients { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public int CategoryId { get; set; }

        public int Weight { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public decimal Price { get; set; }

        public decimal PriceForPizzaBig { get; set; }

        public decimal PriceForPizzaFamily { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public required string ImageUrl { get; set; }
    }
}
