namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SportCar : Car
    {
        private double defaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel)
           : base(horsePower, fuel)
        {
            
        }

        public override double FuelConsumption => defaultFuelConsumption;
    }
}
