namespace P011_AbscraftFactory.Models
{
    using System.Text;

    using P011_AbscraftFactory.Models.Contracts;

    public abstract class Chair : IChair
    {
        public Chair(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public string Model {get; private set; }

        public decimal Price { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Price: {this.Price}");
            sb.AppendLine($"Type: {this.GetType().Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
