namespace P01_AbscractFactory
{
    using System;
    using System.Collections.Generic;

    using P01_AbscractFactory.Factories;
    using P01_AbscractFactory.Providers;

    public class StartUp
    {
        public static void Main()
        {
            IProvider provider = new Provider(new McDonaldFactory());
            IProvider provider1 = new Provider(new KFSFactory());

            var pizzaIngredients = new Dictionary<string, double> { { "Peporoni", 50 }, { "Cheese", 150 } };

            var mcBurgerResult = provider.DeliverBurger();
            var kfsBurger = provider1.DeliverBurger();
            var mcPizzaResult = provider.DeliverPizza(pizzaIngredients);

            Console.WriteLine(mcBurgerResult);
            Console.WriteLine();
            Console.WriteLine(kfsBurger);
            Console.WriteLine();
            Console.WriteLine(mcPizzaResult);
        }
    }
}
