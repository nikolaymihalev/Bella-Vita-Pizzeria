using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BellaVitaPizzeria.Infrastructure.Data.Configurations
{
    internal class SeedData
    {
        public SeedData()
        {
            SeedUsers();
            SeedCategories();
            SeedProducts();
            SeedRatings();
            SeedFavoriteProducts();
            SeedPurchases();
            SeedCarts();
        }
        public IdentityUser Buyer { get; private set; } = null!;
        public IdentityUser Guest { get; private set; } = null!;
        public Category Pizza { get; private set; } = null!;
        public Category Pasta { get; private set; } = null!;
        public Product Carbonara { get; private set; } = null!;
        public Product Bolognese { get; private set; } = null!;
        public Rating FiveStarRating { get; private set; } = null!;
        public Rating ThreeStarRating { get; private set; } = null!;
        public FavoriteProduct FirstFavoriteProduct { get; private set; } = null!;
        public Purchase FirstPurchase { get; private set; } = null!;
        public Cart BuyerCart { get; private set; } = null!;

        private void SeedUsers() 
        {
            var hasher = new PasswordHasher<IdentityUser>();

            Buyer = new IdentityUser()
            {
                Id = "1e22d31e-db95-4032-9165-2ccaa4865169",
                UserName = "buyer@gmail.com",
                NormalizedUserName = "buyer@gmail.com",
                Email = "buyer@gmail.com",
                NormalizedEmail = "buyer@gmail.com"
            };

            Guest = new IdentityUser()
            {
                Id = "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                UserName = "guest@gmail.com",
                NormalizedUserName = "guest@gmail.com",
                Email = "guest@gmail.com",
                NormalizedEmail = "guest@gmail.com"
            };

            Buyer.PasswordHash = hasher.HashPassword(Buyer,"buyer1234");
            Guest.PasswordHash = hasher.HashPassword(Guest,"guest1234");
        }

        private void SeedCategories() 
        {
            Pizza = new Category()
            {
                Id = 1,
                Name = "Pizza"
            };

            Pasta = new Category()
            {
                Id = 2,
                Name = "Pasta"
            };
        }

        private void SeedProducts() 
        {
            Carbonara = new Product()
            {
                Id = 1,
                Title = "Carbonara",
                Description = "Pizza with homemade fresh dough (gluten), cream (dairy product), prosciutto cotto, yellow cheese (dairy product), egg (egg)",
                Image = File.ReadAllBytes(Path.Combine(@"..\..\Bella Vita Pizzeria\BellaVitaPizzeria.Infrastructure\Images", "carbonara.jpg")),
                CategoryId = Pizza.Id,
                MinimumPrice = 15.00,
                MiddlePrice = 16.00,
                MaximumPrice = 43.00,
                MinimumSize = "24 cm",
                MiddleSize = "30 cm",
                MaxmimumSize = "60 cm"
            };

            Bolognese = new Product()
            {
                Id = 2,
                Title = "Bolognese",
                Description = "Freshly cooked pasta (gluten), tomato sauce, Bolognese sauce (minced meat, onions, carrots), yellow cheese (dairy product), olive",
                Image = File.ReadAllBytes(Path.Combine(@"..\..\Bella Vita Pizzeria\BellaVitaPizzeria.Infrastructure\Images", "bolognese.jpg")),
                CategoryId = Pasta.Id,
                MinimumPrice = 15.50,
                MinimumSize = "400 gr",
            };
        }

        private void SeedRatings() 
        {
            FiveStarRating = new Rating()
            {
                ProductId = Carbonara.Id,
                UserId = Guest.Id,
                Value = 5
            };

            ThreeStarRating = new Rating()
            {
                ProductId = Bolognese.Id,
                UserId = Buyer.Id,
                Value = 3
            };
        }

        private void SeedFavoriteProducts() 
        {
            FirstFavoriteProduct = new FavoriteProduct()
            {
                ProductId = Carbonara.Id,
                UserId = Guest.Id,
            };
        }

        private void SeedPurchases() 
        {
            FirstPurchase = new Purchase()
            {
                Id = 1,
                Title = Carbonara.Title,
                Size = Carbonara.MinimumSize,
                Image = Carbonara.Image,
                Quantity = 2,
                UnitPrice = Carbonara.MinimumPrice,
            };
        }

        private void SeedCarts() 
        {
            BuyerCart = new Cart()
            {
                UserId = Buyer.Id,
                PurchaseId = FirstPurchase.Id,
            };
        }
    }
}
