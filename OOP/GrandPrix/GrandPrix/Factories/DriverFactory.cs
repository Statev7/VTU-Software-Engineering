namespace GrandPrix.Factories
{
    using System;
    using System.Collections.Generic;

    using GrandPrix.Models.Cars;
    using GrandPrix.Models.Drivers;

    public class DriverFactory
    {
        public Driver Create(List<string> arguments, Car car)
        {
            Driver driver = null;
            
            string type = arguments[0];
            string name = arguments[1];

            switch (type)
            {
                case "Aggressive": driver = new AggressiveDriver(name, car); break;
                case "Endurance": driver = new EnduranceDriver(name, car); break;
            }

            return driver;
        }
    }
}
