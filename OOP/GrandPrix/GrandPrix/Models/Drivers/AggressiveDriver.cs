namespace GrandPrix.Models.Drivers
{
    using System;

    using GrandPrix.Models.Cars;

    public class AggressiveDriver : Driver
    {
        public AggressiveDriver(string name, Car car) 
            : base(name, car, 2.7)
        {

        }

        public override double Speed => base.Speed * 1.3; 
    }
}
