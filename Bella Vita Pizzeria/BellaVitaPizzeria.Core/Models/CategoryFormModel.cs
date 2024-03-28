using BellaVitaPizzeria.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class CategoryFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.CategoryNameMaxLength, 
            MinimumLength = ValidationConstants.CategoryNameMinLength, 
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
