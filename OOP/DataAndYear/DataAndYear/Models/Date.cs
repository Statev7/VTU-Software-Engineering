namespace DataAndYear
{
    using System;
    using System.Text;

    public class Date
    {
        private const byte MIN_DAY_VALUE = 1;
        private const byte MAX_DAY_VALUE = 31;
        private const byte MIN_MONTH_VALUE = 1;
        private const byte MAX_MONTH_VALUE = 12;
        private const int MAX_YEAR_VALUE = int.MaxValue;
        private const string INVALID_DATE_ERROR_MESSAGE = "The date cannot be more than 31 or less than 1";
        private const string INVALID_MONTH_ERROR_MESSAGE = "The month cannot be more than 12 or less than 1";
        private const string INVALID_YEAR_ERROR_MESSAGE = "The year cannot be more than {0} or less than 1";

        private int day;
        private int month;
        private int year;
        private StringBuilder stringBuilder;

        public Date(int date, int month, int year)
        {
            this.stringBuilder = new StringBuilder();
            this.Day = date;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                bool isInvalid = value > MAX_DAY_VALUE || value < MIN_DAY_VALUE;

                if (isInvalid)
                {
                    throw new Exception(INVALID_DATE_ERROR_MESSAGE);
                }

                this.day = value;
            }
        }

        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                bool isInvalid = value > MAX_MONTH_VALUE || value < MIN_MONTH_VALUE;

                if (isInvalid)
                {
                    throw new Exception(INVALID_MONTH_ERROR_MESSAGE);
                }

                this.month = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                bool isInvalid = value > MAX_YEAR_VALUE || value < MIN_DAY_VALUE;

                if (isInvalid)
                {
                    stringBuilder.Clear();

                    stringBuilder.Append(string.Format(INVALID_YEAR_ERROR_MESSAGE, int.MaxValue));

                    throw new Exception(stringBuilder.ToString());
                }

                this.year = value;
            }
        }

        public void Add(int n)
        {
            bool isLeap = DateTime.IsLeapYear(this.year);

            int daysCount = DaysInMounth(this.month, isLeap);

            Compatibility(this.day, daysCount);

            int sum = this.day + n;

            while (sum > daysCount)
            {
                if (this.month > MAX_MONTH_VALUE)
                {
                    this.year++;
                    this.month = MIN_MONTH_VALUE - 1;
                }

                sum -= daysCount;

                this.month++;
                daysCount = DaysInMounth(this.month, isLeap);
            }

            this.day = sum;
        }

        public void Remove(int n)
        {
            bool isLeap = DateTime.IsLeapYear(this.year);

            int daysCount = DaysInMounth(this.month, isLeap);

            Compatibility(this.day, daysCount);

            int sum = this.day - n;

            if (sum > 0)
            {
                this.day = sum;
            }

            while (sum <= 0)
            {
                if (this.month < MIN_MONTH_VALUE)
                {
                    this.year--;
                    this.month = MAX_MONTH_VALUE + 1;
                }

                this.month--;
                daysCount = DaysInMounth(this.month, isLeap);
                sum = daysCount - Math.Abs(sum);
                this.day = sum;
            }

        }

        private static int DaysInMounth(int month, bool isLeap)
        {
            int count = 0;

            switch (month)
            {
                case 1: count = 31; break;
                case 2: count = isLeap ? 29 : 28; break;
                case 3: count = 31; break;
                case 4: count = 30; break;
                case 5: count = 31; break;
                case 6: count = 30; break;
                case 7: count = 31; break;
                case 8: count = 31; break;
                case 9: count = 30; break;
                case 10: count = 31; break;
                case 11: count = 30; break;
                case 12: count = 31; break;
            }

            return count;
        }

        private void Compatibility(int userDate, int daysCountPerMonth)
        {
            if (userDate > daysCountPerMonth)
            {
                throw new Exception("Incompatibility");
            }
        }

        public override string ToString()
        {
            stringBuilder.Clear();

            stringBuilder.Append($"Date: {this.Day} Month: {this.Month} Year: {this.Year}");

            return stringBuilder.ToString();
        }
    }
}
