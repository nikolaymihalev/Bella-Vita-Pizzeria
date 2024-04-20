namespace BellaVitaPizzeria.Infrastructure.Constants
{
    public static class ValidationConstants
    {
        public const int CategoryNameMinLength = 3;
        public const int CategoryNameMaxLength = 50;

        public const int ProductTitleMinLength = 3;
        public const int ProductTitleMaxLength = 150;
        
        public const int ProductWeightMinLength = 1;
        public const int ProductWeightMaxLength = 15;

        public const int ProductMinRating = 0;
        public const int ProductMaxRating = 5;

        public const int MaxProductsPerPage = 10;

        public const int ClientNameMaxLength = 150;
        public const int ClientNameMinLength = 2;

        public const int ClientEmailMaxLength = 200;
        public const int ClientEmailMinLength = 5;

        public const int ClientPhoneNumberMaxLength = 20;
        public const int ClientPhoneNumberMinLength = 5;

        public const int ClientTownMaxLength = 50;
        public const int ClientTownMinLength = 2;

        public const int ClientStreetMaxLength = 80;
        public const int ClientStreetMinLength = 3;
    }
}
