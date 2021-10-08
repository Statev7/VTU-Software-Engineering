namespace Minedraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput) 
            : base(id, energyOutput)
        {
            this.EnergyOutput = this.EnergyOutput * 1.5;
        }
    }
}
