using BellaVitaPizzeria.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    /// <summary>
    /// Обект за прехвърляне на данни за продукт
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// Идентификатор на продукта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на продукта
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductTitleMaxLength, 
            MinimumLength = ValidationConstants.ProductTitleMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public required string Title { get; set; }

        /// <summary>
        /// Съставки на продукта
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.ProductIngredientsMaxLength,
            MinimumLength = ValidationConstants.ProductIngredientsMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public required string Ingredients { get; set; }

        /// <summary>
        /// Идентификатор на категорията на продукта
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Тегло на продукта
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Цена на продукта
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public decimal Price { get; set; }

        /// <summary>
        /// Цена за продукт(пица) голяма
        /// </summary>
        public decimal PriceForPizzaBig { get; set; }

        /// <summary>
        /// Цена за продукт(пица) семейна
        /// </summary>
        public decimal PriceForPizzaFamily { get; set; }

        /// <summary>
        /// Снимка на продукта
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        public required string ImageUrl { get; set; }

        public CategoryDto CategoryDto { get; set; }
    }
}
