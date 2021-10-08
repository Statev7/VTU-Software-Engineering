namespace Minedraft.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class Validator
    {
        public static bool NegativeNumberCheckSystem(double value)
        {
            bool isValid = true;

            if (value < 0)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool HarvestersEnergyRequirementCheckSystem(double value)
        {
            bool isValid = true;

            if (value > 20000)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool ProvidersEnergyRequirementCheckSystem(double value)
        {
            bool isValid = true;

            if (value > 10000)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
