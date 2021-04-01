namespace P01_ClassBoxData.Models
{
    using System;

    public class Box
    {
        private const int MIN_VALUE = 0;
        private const string SIDE_ZERO_OR_NEGATIVE_VALUE_ERROR_MESSAGE = "{0} cannot be zero or negative.";

        private double lenght;
        private double width;
        private double height;
        private double result;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
            this.result = 0;
        }

        public double Lenght
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                this.Validator(value, nameof(this.Lenght));

                this.lenght = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.Validator(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.Validator(value, nameof(this.Height));

                this.height = value;
            }
        }

        private void Validator(double value, string side)
        {
            if (value <= MIN_VALUE)
            {
                throw new ArgumentException(String.Format(SIDE_ZERO_OR_NEGATIVE_VALUE_ERROR_MESSAGE, side));
            }

        }

        public void SurfaceArea(double lenght, double width, double height)
        {

            this.result = (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);

            Console.WriteLine($"Surface Area - {this.result:F2}");
        }

        public void LateralSurfaceArea(double lenght, double width, double height)
        {

            this.result = (2 * lenght * height) + (2 * width * height);

            Console.WriteLine($"Lateral Surface Area - {this.result:F2}");
        }

        public void Volume(double lenght, double width, double height)
        {

            this.result = lenght * width * height;

            Console.WriteLine($"Volume - {this.result:F2}");
        }
    }
}
