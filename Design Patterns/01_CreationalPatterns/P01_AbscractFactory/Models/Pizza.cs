namespace P01_AbscractFactory.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class Pizza
    {
        private const int INITIAL_WEIGHT = 0;

        private readonly IDictionary<string, double> ingredientsDate;

        public Pizza()
        {
            this.ingredientsDate = new Dictionary<string, double>();
        }

        public IReadOnlyDictionary<string, double> Ingredients => (IReadOnlyDictionary<string, double>)this.ingredientsDate;

        public void AddIngredents(IDictionary<string, double> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                string key = ingredient.Key;
                double value = ingredients[key];

                if (this.ingredientsDate.ContainsKey(key) == false)
                {
                    this.ingredientsDate[key] = INITIAL_WEIGHT;
                }

                this.ingredientsDate[key] += value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var ingredient in this.Ingredients)
            {
                sb.AppendLine($"{ingredient.Key} -> {ingredient.Value}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}