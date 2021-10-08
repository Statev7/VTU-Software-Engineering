namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car : Vehicle
    {
        private double defaultFuelConsumption = 3;
        public Car(int horsePower, double fuel)
           : base(horsePower, fuel)
        {
            
        }

        public override double FuelConsumption { get => defaultFuelConsumption; }
    }
}
