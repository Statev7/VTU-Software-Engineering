namespace GrandPrix.Models.Tyres
{
    using System;

    public class HardTyre : Tyre
    {
        public HardTyre(double hardness) 
            : base(hardness)
        {
        }

        public override string Name => "Hard";
    }
}
