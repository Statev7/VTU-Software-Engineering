namespace P01_AbscractFactory.Providers
{
    using System.Collections.Generic;

    using P01_AbscractFactory.Factories.Contracts;
    using P01_AbscractFactory.Models;

    public class Provider : IProvider
    {
        private readonly IFactory factory;

        public Provider(IFactory factory)
        {
            this.factory = factory;
        }

        public Burger DeliverBurger()
        {
           return factory.CreateBurger();
        }

        public Pizza DeliverPizza(IDictionary<string, double> ingredients)
        {
            return factory.CreatePizza(ingredients);
        }
    }
}
