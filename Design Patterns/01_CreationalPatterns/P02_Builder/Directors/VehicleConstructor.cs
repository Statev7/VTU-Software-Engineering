namespace P02_Builder.Directors
{
    using P02_Builder.Builders;

    public class VehicleConstructor 
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildFrame(null);
            builder.BuildWheels(0);
            builder.BuildColor(null);
        }
    }
}
