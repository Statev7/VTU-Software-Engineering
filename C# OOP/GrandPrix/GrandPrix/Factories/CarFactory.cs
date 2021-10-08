namespace GrandPrix.Factories
{
    using System;
    using System.Collections.Generic;

    using GrandPrix.Models;
    using GrandPrix.Models.Cars;

    public class CarFactory
    {
        public Car Create(List<string> arguments, Tyre tyre)
        {
            int hp = int.Parse(arguments[0]);
            double fuelAmount = double.Parse(arguments[1]);

            Car car = new Car(hp, fuelAmount, tyre);

            return car;
        }
    }
}
