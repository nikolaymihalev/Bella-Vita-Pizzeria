using Azure;
using BellaVitaPizzeria.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Client's order")]
    public class Order
    {
        private List<int> _purchasesIds = new List<int>();

        [Comment("Order identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Client's first name")]
        [MaxLength(ValidationConstants.ClientNameMaxLength)]
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Comment("Client's last name")]
        [MaxLength(ValidationConstants.ClientNameMaxLength)]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [Comment("Client's email")]
        [MaxLength(ValidationConstants.ClientEmailMaxLength)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Comment("Client's phone number")]
        [MaxLength(ValidationConstants.ClientPhoneNumberMaxLength)]
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Comment("Client's address - town")]
        [MaxLength(ValidationConstants.ClientTownMaxLength)]
        [Required]
        public string Town { get; set; } = string.Empty;

        [Comment("Client's address - street")]
        [MaxLength(ValidationConstants.ClientStreetMaxLength)]
        [Required]
        public string Street { get; set; } = string.Empty;

        [Comment("Client's comment")]
        public string Comment { get; set; } = string.Empty;

        [Comment("Client's identifier")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }

        [Comment("Purchases total sum")]
        [Required]
        public double TotalSum { get; set; }

        [Comment("Is order completed")]
        public bool IsCompleted { get; set; }

        public IEnumerable<int> PurchasesIds => _purchasesIds;
        public void AddPurchases(int[] purchasesIds) => _purchasesIds = new List<int>(_purchasesIds.Union(purchasesIds));
    }
}
