using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    public class Pasta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Ingredients { get; set; }

        [Required]
        public required string Weight { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
