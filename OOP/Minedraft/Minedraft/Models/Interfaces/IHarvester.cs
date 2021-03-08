namespace Minedraft.Models.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IHarvester
    {
        string Id { get; set; }
        double OreOutput { get; set; }
        double EnergyRequirement  { get; set; }
    }
}
