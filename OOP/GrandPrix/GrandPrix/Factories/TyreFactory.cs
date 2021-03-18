namespace GrandPrix.Factories
{

    using System;
    using System.Collections.Generic;

    using GrandPrix.Models;
    using GrandPrix.Models.Tyres;

    public class TyreFactory
    {
        public Tyre Create(List<string> arguments)
        {
            Tyre tyre = null;

            string tyreType = arguments[0];
            var tyreHardness = double.Parse(arguments[1]);

            switch (tyreType)
            {
                case "Hard":
                    tyre = new HardTyre(tyreHardness);
                    break;
                case "Ultrasoft":
                    double grip = double.Parse(arguments[2]);

                    tyre = new UltrasoftType(tyreHardness, grip);
                    break;
            }

            return tyre;
        }
    }
}
