namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
           : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 3;
        }
    }
}
