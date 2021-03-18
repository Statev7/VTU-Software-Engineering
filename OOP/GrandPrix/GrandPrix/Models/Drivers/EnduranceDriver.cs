namespace GrandPrix.Models.Drivers
{
    using System;

    using GrandPrix.Models.Cars;

    public class EnduranceDriver : Driver
    {
        public EnduranceDriver(string name, Car car) 
            : base(name, car, 1.5)
        {

        }
    }
}
