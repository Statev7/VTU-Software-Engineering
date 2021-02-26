namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 8;
        }
    }
}