namespace _02_BankApp.Utilities.Messages
{
    public static class ExceptionMessages
    {
        public const string CLIENT_ALREADY_REGISTERED_ERROR_MESSAGE = "{0} {1} is already a client!";

        public const string CLIENT_NOT_EXIST_ERROR_MESSAGE = "Invalid client!";

        public const string MIN_DEPOSIT_AMOUT_ERROR_MESSAGE = "The minimum deposit amount is {0}!";

        public const string BANK_DOES_NOT_HAVE_ENOUGH_MONEY = "The bank does not have enough money";

        public const string MIN_LOAD_ERROR_MESSAGE = "The loan cannot be less than {0}$";

        public const string NULL_NAME_ERROR_MESSAGE = "{0} cannot be null or whitespace!";

        public const string NAME_MIN_LENGHT_ERROR_MESSAGE = "{0} cannot contain fewer than {1} symbols!";

        public const string INVALID_IDENTIFICATION_NUMBER = "The identification number is invalid!";
    }
}
