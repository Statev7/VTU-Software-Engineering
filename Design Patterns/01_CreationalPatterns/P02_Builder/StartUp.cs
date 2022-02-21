namespace P02_Builder
{
    using System;

    using P02_Builder.Builders;
    using P02_Builder.Directors;
    using P02_Builder.Models;

    public class StartUp
    {
        public static void Main()
        {
            VehicleConstructor vehicleConstructor = new VehicleConstructor();
            VehicleBuilder carBuilder = new CarBuilder();

            vehicleConstructor.Construct(carBuilder);

            Vehicle car = new CarBuilder()
                .BuildColor("red")
                .BuildFrame("Something")
                .Build();

            Console.WriteLine(car.Color);

            string carResult = carBuilder.Vehicle.Show();
            Console.WriteLine(carResult);
        }
    }
}
