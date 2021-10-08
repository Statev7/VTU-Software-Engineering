namespace DateTime
{

    using System;
    using System.Text;

    public struct Date
    {
        private DateTime time;

        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public void AddDays(int n)
        {
            DateTime result = this.time.AddDays(n);

            this.time = result;
        }

        public void RemoveDays(int n)
        {
            int subtractionNumber = n * -1;

            DateTime result = this.time.AddDays(subtractionNumber);

            this.time = result;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Time}");

            return str.ToString();
        }
    }
}
