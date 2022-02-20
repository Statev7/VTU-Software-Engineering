namespace P01_AbscractFactory.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class Burger 
    {
        public Burger()
        {
            this.Ingredients = new HashSet<string>();
        }

        public HashSet<string> Ingredients { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var ingredient in this.Ingredients)
            {
                sb.AppendLine(ingredient);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
