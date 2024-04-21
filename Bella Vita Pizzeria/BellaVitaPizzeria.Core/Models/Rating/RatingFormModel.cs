using BellaVitaPizzeria.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models.Rating
{
    public class RatingFormModel
    {
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [Range(ValidationConstants.ProductMinRating,
            ValidationConstants.ProductMaxRating,
            ErrorMessage = ErrorMessagesConstants.RatingErrorMessage)]
        public int Value { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public int ProductId { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}
