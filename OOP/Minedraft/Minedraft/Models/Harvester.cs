namespace Minedraft
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Common;
    using Models.Interfaces;
    public class Harvester : IHarvester
    {
        private string id;
        private double oreOutput;
        private double energyRequirement;

        public Harvester(string id, double oreOutput, double energyRequirement)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public string Id { get; set; }
        public double OreOutput
        {
            get
            {
                return oreOutput;
            }
            set
            {
                string exeption = string.Empty;
                bool isValid = true;

                if (isValid != Validator.NegativeNumberCheckSystem(value))
                {
                    exeption = ErrorMessages.VALUE_NEGATIVE_ERROR_MESSAGE;
                }

                if (exeption.Length != 0)
                {
                    throw new Exception(exeption);
                }

                oreOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get
            {
                return energyRequirement;
            }
            set
            {
                string exeption = string.Empty;
                bool isValid = true;

                if (isValid != Validator.NegativeNumberCheckSystem(value))
                {
                    exeption = ErrorMessages.VALUE_NEGATIVE_ERROR_MESSAGE;
                }
                else if (isValid != Validator.HarvestersEnergyRequirementCheckSystem(value))
                {
                    exeption = ErrorMessages.VALUE_OVER_TWENTY_THOUSAND_ENERGY_ERROR_MESSAGE;
                }

                if (exeption.Length != 0)
                {
                    throw new Exception(exeption);
                }

                energyRequirement = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Id: {this.Id} oreOutput: {this.OreOutput} energyRequirement: {this.EnergyRequirement}");
            return str.ToString();
        }
    }
}
