namespace Minedraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class HammerHarvester : Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement)
            : base(id, oreOutput, energyRequirement)
        {
            this.OreOutput = (200 / 100) * this.OreOutput;
            this.EnergyRequirement = this.EnergyRequirement * 2.0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
