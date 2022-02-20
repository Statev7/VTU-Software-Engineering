namespace P01_AbscractFactory.Factories
{
    using System.Collections.Generic;

    using P01_AbscractFactory.Models;

    public class McDonaldFactory : Factory
    {
        public override Burger CreateBurger()
        {
            var burger = new Burger();

            burger.Ingredients.Add("Meatball");
            burger.Ingredients.Add("Cheese");
            burger.Ingredients.Add("Onion");

            return burger;
        }

        public override Pizza CreatePizza(IDictionary<string, double> ingredients)
        {
            var pizza = new Pizza();
            pizza.AddIngredents(ingredients);

            return pizza;
        }
    }
}
