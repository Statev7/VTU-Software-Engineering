namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Cake : Dessert
    {
        private double grams = 350;
        private double calories = 1000;
        private decimal cakePrice = 5;
        public Cake(string name, decimal price, double grams, double calories)
            : base(name, price, grams, calories)
        {
            
        }

        public override double Grams { get => grams; }
        public override double Calories { get => calories; }
        public override decimal Price { get => cakePrice; }
    }
}
