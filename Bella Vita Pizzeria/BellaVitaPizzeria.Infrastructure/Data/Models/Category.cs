using BellaVitaPizzeria.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Таблица за категориите за продукт")]
    public class Category
    {
        [Key]
        [Comment("Идентификатор на категорията")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CategoryNameMaxLength)]
        [Comment("Име на категорията")]
        public required string Name { get; set; }
    }
}
