namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Dessert : Food
    {
        private double calories;
        public Dessert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            this.Calories = calories;
        }

        public virtual double Calories { get; set; }
    }
}
