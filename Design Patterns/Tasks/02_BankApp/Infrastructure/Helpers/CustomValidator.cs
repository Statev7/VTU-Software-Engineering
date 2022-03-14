namespace _02_BankApp.Infrastructure.Helpers
{
    using System.Text.RegularExpressions;

    public static class CustomValidator
    {
        private static string PATTERN = @"[0-9]{10}";

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

        public static bool IsIdentificationNumberValid(string value)
        {
            Regex regex = new Regex(PATTERN);

            bool isValid = regex.Matches(value).Count != 0;
            return isValid;
        }
    }
}
