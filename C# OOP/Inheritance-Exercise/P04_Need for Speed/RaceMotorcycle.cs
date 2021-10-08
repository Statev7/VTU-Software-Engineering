﻿namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RaceMotorcycle : Motorcycle
    {
        private double defaultFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption { get => defaultFuelConsumption; }
    }
}