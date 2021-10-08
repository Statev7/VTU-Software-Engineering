namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Coffee : HotBeverage
    {
        private double coffeeMillilites = 50;
        private decimal coffeePrice = 3.50M;
        public Coffee(string name, double caffeine)
            : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }

        public override double Milliliters { get => coffeeMillilites; }
        public override decimal Price { get => coffeePrice; }
        public double Caffeine { get; set; }
    }
}
