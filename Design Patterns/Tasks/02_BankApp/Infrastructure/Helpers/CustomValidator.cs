namespace _02_BankApp.Infrastructure.Helpers
{
    public static class CustomValidator
    {
        public static bool IsStringLengthLowerTo(string value, int lenght)
        {
            bool isValid = value.Length < lenght;

            return isValid;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsBelowZero(double value)
        {
            return value < 0;
        }
    }
}
