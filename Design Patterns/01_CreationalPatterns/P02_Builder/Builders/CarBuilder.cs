namespace P02_Builder.Builders
{
    using P02_Builder.Models;

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Car();
        }

        public override void BuildFrame(string frame)
        {
            this.Vehicle.Frame = frame;
        }

        public override void BuildWheels(int wheels)
        {
            this.Vehicle.NumberOfWheels = wheels;
        }

        public override void BuildColor(string color)
        {
            this.Vehicle.Color = color;
        }
    }
}
