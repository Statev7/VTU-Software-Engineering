namespace P05_Prototype.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P05_Prototype.Factory;
    using P05_Prototype.Models;

    public class Manager
    {
        private readonly ICollection<Vehicle> vehicles;
        private VehicleFactory vehicleFactory;

        public Manager()
        {
            this.vehicleFactory = new VehicleFactory();
            this.vehicles = new List<Vehicle>();
        }

        public string RegisetVehicle(params string[] arguments)
        {
            Vehicle vehicle = this.vehicleFactory.Create(arguments);

            this.vehicles.Add(vehicle);
            return $"Successfully registered car with model: {vehicle.Model}";
        }

        public string CloneVehicle(string model)
        {
            Vehicle vehicle = FindVehicle(model);

            Vehicle clonedVihicle = vehicle.DeepClone();
            this.vehicles.Add(clonedVihicle);

            return $"Successfully cloned a car with model: {vehicle.Model}";
        }

        public void Print()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.vehicles));
        }

        private Vehicle FindVehicle(string model)
        {
            return this.vehicles.SingleOrDefault(v => v.Model == model);
        }
    }
}
