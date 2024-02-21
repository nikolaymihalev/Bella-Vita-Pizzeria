using BellaVitaPizzeria.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Core.Models
{
    /// <summary>
    /// Обект за прехвърляне на данни за категория
    /// </summary>
    public class CategoryDto
    {
        /// <summary>
        /// Идентификатор на категорията
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на категорията
        /// </summary>
        [Required(ErrorMessage = ErrorMessagesConstants.RequireErrorMessage)]
        [StringLength(ValidationConstants.CategoryNameMaxLength,
            MinimumLength = ValidationConstants.CategoryNameMinLength,
            ErrorMessage = ErrorMessagesConstants.StringLengthErrorMessage)]
        public required string Name { get; set; }
    }
}
