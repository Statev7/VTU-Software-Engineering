namespace P02_Builder.Builders
{
    using P02_Builder.Models;

    public class BusBuilder : VehicleBuilder
    {
        public BusBuilder()
        {
            this.Vehicle = new Bus();
        }

        public override VehicleBuilder BuildFrame(string frame)
        {
            this.Vehicle.Frame = frame;
            return this;
        }

        public override VehicleBuilder BuildWheels(int wheels)
        {
            this.Vehicle.NumberOfWheels = wheels;
            return this;
        }

        public override VehicleBuilder BuildColor(string color)
        {
            this.Vehicle.Color = color;
            return this;
        }

        public override Vehicle Build()
        {
            return this.Vehicle;
        }
    }
}
