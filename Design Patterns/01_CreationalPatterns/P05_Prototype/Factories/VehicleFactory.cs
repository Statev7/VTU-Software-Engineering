namespace P05_Prototype.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P05_Prototype.Models;

    public class VehicleFactory
    {
        public Vehicle Create(params string[] arguments)
        {
            Type type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Name.ToLower() == arguments[0].ToLower())
                .FirstOrDefault();

            string model = arguments[1];
            int engineSpeed = int.Parse(arguments[2]);
            int enginePower = int.Parse(arguments[3]);
            string color = arguments[4];

            CarEngine engine = new CarEngine(engineSpeed, enginePower);

            object[] constructureArguments = new object[] { model, engine, color };
            Vehicle vehicle = (Vehicle)Activator.CreateInstance(type, constructureArguments);

            return vehicle;
        }

        public Vehicle Clone(Vehicle vehicle)
        {
            Vehicle clonedVihicle = vehicle.DeepClone();

            return clonedVihicle;
        }
    }
}
