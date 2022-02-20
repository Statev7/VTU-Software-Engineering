namespace P02_Builder.Models
{
    using System.Text;

    public class Vehicle
    {
        public string Frame { get; set; }

        public int NumberOfWheels { get; set; }

        public string Color { get; set; }

        public string Show()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"  Frame: {this.Frame}");
            sb.AppendLine($"  NumberOfWheels: {this.NumberOfWheels}");
            sb.AppendLine($"  Color: {this.Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
