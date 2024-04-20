using BellaVitaPizzeria.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class OrderFormModel
    {
        public int Id { get; set; }

        [StringLength(ValidationConstants.ClientNameMaxLength, 
            MinimumLength = ValidationConstants.ClientNameMinLength, 
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(ValidationConstants.ClientNameMaxLength,
            MinimumLength = ValidationConstants.ClientNameMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(ValidationConstants.ClientEmailMaxLength,
            MinimumLength = ValidationConstants.ClientEmailMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string Email { get; set; } = string.Empty;

        [StringLength(ValidationConstants.ClientPhoneNumberMaxLength,
            MinimumLength = ValidationConstants.ClientPhoneNumberMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(ValidationConstants.ClientTownMaxLength,
            MinimumLength = ValidationConstants.ClientTownMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string Town { get; set; } = string.Empty;

        [StringLength(ValidationConstants.ClientStreetMaxLength,
            MinimumLength = ValidationConstants.ClientStreetMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public string Street { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}
