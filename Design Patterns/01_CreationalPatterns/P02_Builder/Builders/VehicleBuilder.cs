namespace P02_Builder.Builders
{
    using P02_Builder.Models;

    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }

        public abstract void BuildFrame(string frame);

        public abstract void BuildColor(string color);

        public abstract void BuildWheels(int wheels);
    }
}
