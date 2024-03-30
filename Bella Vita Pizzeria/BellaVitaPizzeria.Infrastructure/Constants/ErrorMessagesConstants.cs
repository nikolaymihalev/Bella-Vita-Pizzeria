namespace BellaVitaPizzeria.Infrastructure.Constants
{
    public static class ErrorMessagesConstants
    {
        public const string RequireErrorMessage = "The field {0} is required!";
        public const string StringLengthErrorMessage = "The field {0} is between {2} and {1} characters long!";
        public const string OperationFailedErrorMessage = "Operation failed. Try again!";
        public const string InvalidModelErrorMessage = "Invalid {0}!";
        public const string DoesntExistErrorMessage = "This {0} doesn't exist!";
        public const string RatingErrorMessage = "The rating must be between {1} and {2}!";
    }
}
