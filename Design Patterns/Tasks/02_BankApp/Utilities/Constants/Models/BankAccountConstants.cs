namespace _02_BankApp.Utilities.Constants.Models
{
    public static class BankAccountConstants
    {
        //Regular 
        public const int MIN_REGULAR_BALANCE_VALUE = 0;
        public const int MAX_REGULAR_BALANCE_VALUE = 100000;
        public const double REGULAR_INTEREST_RATE_VALUE = 0.01;

        //Bronze
        public const int MIN_BRONZE_BALANCE_VALUE = 100001;
        public const int MAX_BRONZE_BALANCE_VALUE = 200000;
        public const double BRONZE_INTEREST_RATE_VALUE = 0.05;

        //Gold
        public const int MIN_GOLD_BALANCE_VALUE = 200001;
        public const int MAX_GOLD_BALANCE_VALUE = 500000;
        public const double GOLD_INTEREST_RATE_VALUE = 0.075;

        //Platinum
        public const double PLATINUM_INTEREST_RATE_VALUE = 1.1;
    }
}
