namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel)
           : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 10;
        }
    }
}
