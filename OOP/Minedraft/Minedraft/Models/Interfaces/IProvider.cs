namespace Minedraft.Models.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IProvider
    {
        string Id { get; set; }
        double EnergyOutput { get; set; }

    }
}
