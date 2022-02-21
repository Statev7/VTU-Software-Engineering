namespace P02_Builder.Builders
{
    using P02_Builder.Models;

    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }

        public abstract VehicleBuilder BuildFrame(string frame);

        public abstract VehicleBuilder BuildColor(string color);

        public abstract VehicleBuilder BuildWheels(int wheels);

        public abstract Vehicle Build();
    }
}
