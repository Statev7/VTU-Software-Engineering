namespace DateTime
{

    using System;
    using System.Text;

    public struct Date
    {
        private DateTime day;

        public DateTime Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public void AddDays(int n)
        {
            DateTime result = this.day.AddDays(n);

            this.day = result;
        }

        public void RemoveDays(int n)
        {
            int subtractionNumber = n * -1;

            DateTime result = this.day.AddDays(subtractionNumber);

            this.day = result;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Day}");

            return str.ToString();
        }
    }
}
