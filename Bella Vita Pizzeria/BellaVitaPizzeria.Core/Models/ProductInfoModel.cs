using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Core.Models
{
    public class ProductInfoModel
    {
        public ProductInfoModel(
            int id,
            string title,
            string description,
            string image,
            int categoryId,
            string categoryName,
            double minimumPrice,
            double middlePrice,
            double maximumPrice,
            string minimumSize,
            string middleSize,
            string maximumSize)
        {
            Id = id; 
            Title = title; 
            Description = description;
            Image = image; 
            CategoryId = categoryId;
            CategoryName = categoryName;
            MinimumPrice = minimumPrice;
            MiddlePrice = middlePrice;
            MaximumPrice = maximumPrice;
            MinimumSize = minimumSize;
            MiddleSize = middleSize;
            MaxmimumSize = maximumSize;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public double MinimumPrice { get; set; }

        public double MiddlePrice { get; set; }

        public double MaximumPrice { get; set; }

        [Display(Name ="Small")]
        public string MinimumSize { get; set; }

        [Display(Name = "Big")]
        public string MiddleSize { get; set; }

        [Display(Name = "Family")]
        public string MaxmimumSize { get; set; }
        public bool IsInUserFavoriteCollection { get; set; }
        public double AverageRating { get; set; }
    }
}
