namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Fish : MainDish
    {
        private double grams = 22;
        public Fish(string name, decimal price, double grams)
            : base(name, price, grams)
        {
            
        }

        public override double Grams { get => grams ;}
    }
}
