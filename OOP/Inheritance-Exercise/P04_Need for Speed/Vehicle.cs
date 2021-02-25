namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle
    {
        private double defaultFuelConsumption;
        private double fuelConsumption;
        private double fuel;
        private int horsePower;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public double DefaultFuelConsumption { get; set; } = 1.25;

        public double FuelConsumption { get; set; }

        public void Drive(double kilometers)
        {
            double sum = 0;
            double result = 0;

            sum = kilometers * this.DefaultFuelConsumption;
            result = this.Fuel - sum;

            Console.WriteLine(result);
        }
    }
}
