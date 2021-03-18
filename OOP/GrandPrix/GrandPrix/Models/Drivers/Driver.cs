namespace GrandPrix.Models.Drivers
{
    using System;

    using GrandPrix.Models.Cars;

    public abstract class Driver
    {
        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.TotalTime = 0;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Name { get; set; }
        public double TotalTime { get; set; }
        public Car Car { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

        public virtual void ReduceFuelAmount(int length)
        {
            this.Car.ReduceFuel(length, this.FuelConsumptionPerKm);
        }

        
    }
}
