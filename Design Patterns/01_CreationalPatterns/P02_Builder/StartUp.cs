namespace P02_Builder
{
    using System;

    using P02_Builder.Builders;
    using P02_Builder.Directors;

    public class StartUp
    {
        public static void Main()
        {
            VehicleConstructor vehicleConstructor = new VehicleConstructor();
            VehicleBuilder carBuilder = new CarBuilder();

            vehicleConstructor.Construct(carBuilder);
            carBuilder.BuildColor("White");
            carBuilder.BuildFrame("Something");
            carBuilder.BuildWheels(4);

            string carResult = carBuilder.Vehicle.Show();
            Console.WriteLine(carResult);
        }
    }
}
