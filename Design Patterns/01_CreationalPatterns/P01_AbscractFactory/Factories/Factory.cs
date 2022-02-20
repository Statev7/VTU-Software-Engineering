namespace P01_AbscractFactory.Factories
{
    using System.Collections.Generic;

    using P01_AbscractFactory.Factories.Contracts;
    using P01_AbscractFactory.Models;

    public abstract class Factory : IFactory
    {
        public abstract Burger CreateBurger();

        public abstract Pizza CreatePizza(IDictionary<string, double> ingredients);
    }
}
