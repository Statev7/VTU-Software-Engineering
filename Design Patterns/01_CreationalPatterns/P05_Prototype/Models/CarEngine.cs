namespace P05_Prototype.Models
{
    using System.Text;

    public class CarEngine
    {
        public CarEngine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Engine:");
            sb.AppendLine($"  Speed:{this.Speed}");
            sb.AppendLine($"  Power:{this.Power}");

            return sb.ToString().TrimEnd();
        }
    }
}
