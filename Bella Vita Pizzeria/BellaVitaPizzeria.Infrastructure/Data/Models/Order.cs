using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Client's order")]
    public class Order
    {
        [Comment("Order identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Client's first name")]
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Comment("Client's last name")]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [Comment("Client's email")]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Comment("Client's phone number")]
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Comment("Client's address - town")]
        [Required]
        public string Town { get; set; } = string.Empty;

        [Comment("Client's address - street")]
        [Required]
        public string Street { get; set; } = string.Empty;

        [Comment("Client's comment")]
        [Required]
        public string Comment { get; set; } = string.Empty;

        [Comment("Client's identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }
    }
}
