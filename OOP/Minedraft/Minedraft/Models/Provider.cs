namespace Minedraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Interfaces;
    using Common;

    public class Provider : IProvider
    {
        private string id;
        private double energyOutput;

        public Provider(string id, double energyOutput)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public string Id { get; set; }
        public double EnergyOutput
        {
            get
            {
                return energyOutput;
            }
            set
            {
                string exeption = string.Empty;
                bool isValid = true;

                if (isValid != Validator.NegativeNumberCheckSystem(value))
                {
                    exeption = ErrorMessages.VALUE_NEGATIVE_ERROR_MESSAGE;
                }
                else if (isValid != Validator.ProvidersEnergyRequirementCheckSystem(value))
                {
                    exeption = ErrorMessages.VALUE_OVER_TEN_THOUSAND_ENERGY_ERROR_MESSAGE;
                }

                if (exeption.Length != 0)
                {
                    throw new Exception(exeption);
                }
                energyOutput = value;
            }
        }
    }
}
