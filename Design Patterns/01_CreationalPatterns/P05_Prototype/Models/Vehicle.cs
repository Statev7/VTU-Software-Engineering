using System.Text;

namespace P05_Prototype.Models
{
    public abstract class Vehicle
    {
        public Vehicle(string model, CarEngine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }

        public string Model { get; set; }

        public CarEngine Engine { get; set; }

        public string Color { get; set; }

        public Vehicle DeepClone()
        {
            Vehicle vehicle = (Vehicle)this.MemberwiseClone();
            vehicle.Engine = new CarEngine(Engine.Speed, Engine.Power);
            return vehicle;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine(this.Engine.ToString());
            sb.AppendLine($"Color: {this.Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
