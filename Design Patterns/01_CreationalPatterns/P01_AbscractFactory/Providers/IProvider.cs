namespace P01_AbscractFactory.Providers
{
    using System.Collections.Generic;

    using P01_AbscractFactory.Models;

    public interface IProvider
    {
        Burger DeliverBurger();

        Pizza DeliverPizza(IDictionary<string, double> ingredients);
    }
}
