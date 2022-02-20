namespace P01_AbscractFactory.Factories.Contracts
{
    using System.Collections.Generic;

    using P01_AbscractFactory.Models;

    public interface IFactory
    {
        Burger CreateBurger();

        Pizza CreatePizza(IDictionary<string, double> ingredients);
    }
}
