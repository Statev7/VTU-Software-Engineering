namespace Minedraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SonicHarvester : Harvester
    {
        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) 
            : base(id, oreOutput, energyRequirement)
        {
            this.SonicFactor = sonicFactor;
        }

        public int SonicFactor { get; set; }
    }
}
