namespace P011_AbscraftFactory.Models
{
    using System.Text;

    using P011_AbscraftFactory.Models.Contracts;

    public abstract class CoffeTable : ICoffeTable
    {
        public CoffeTable(double height, double width, string color)
        {
            this.Height = height;
            this.Width = width;
            this.Color = color;
        }

        public double Height { get; private set; }

        public double Width { get; private set; }

        public string Color { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Height: {this.Height}");
            sb.AppendLine($"Width: {this.Width}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Type: {this.GetType().Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
