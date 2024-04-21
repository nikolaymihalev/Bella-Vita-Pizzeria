using BellaVitaPizzeria.Core.Models.Category;
using BellaVitaPizzeria.Infrastructure.Constants;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models.Product
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
        [Display(Name = "Price")]
        public double MinimumPrice { get; set; }

        [Display(Name = "Price for middle size")]
        public double? MiddlePrice { get; set; }

        [Display(Name = "Price for max size")]
        public double? MaximumPrice { get; set; }

        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductWeightMaxLength,
            MinimumLength = ValidationConstants.ProductWeightMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        [Display(Name = "Size")]
        public string MinimumSize { get; set; } = string.Empty;

        [Display(Name = "Middle size")]
        public string? MiddleSize { get; set; }

        [Display(Name = "Max size")]
        public string? MaximumSize { get; set; }

        public IEnumerable<CategoryInfoModel> Categories { get; set; } = new List<CategoryInfoModel>();
    }
}
