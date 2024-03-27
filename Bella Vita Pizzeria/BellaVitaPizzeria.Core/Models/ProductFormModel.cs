using BellaVitaPizzeria.Infrastructure.Constants;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class ProductFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductTitleMaxLength,
            MinimumLength = ValidationConstants.ProductTitleMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public byte[] Image { get; set; } = new byte[128];
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public double MinimumPrice { get; set; }

        public double? MiddlePrice { get; set; }

        public double? MaximumPrice { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductWeightMaxLength,
            MinimumLength = ValidationConstants.ProductWeightMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public string MinimumSize { get; set; } = string.Empty;

        public string? MiddleSize { get; set; }

        public string? MaxmimumSize { get; set; }

        public IEnumerable<CategoryInfoModel> Categories { get; set; } = new List<CategoryInfoModel>();
    }
}
