namespace GrandPrix.Models.Tyres
{
    using System;

    public class UltrasoftType : Tyre
    {
        private const double MIN_DEGRADATION = 30;
        private const string BLOW_TYRE_ERROR_MESSAGE = "Blown Tyre";

        private double degradation;

        public UltrasoftType(double hardness, double grip) 
            : base(hardness)
        {
            this.Grip = grip;
        }

        public double Grip { get; set; }

        public override double Degradation
        {
            get
            {
                return degradation;
            }
            set
            {
                bool isInvalid = value < MIN_DEGRADATION;

                if (isInvalid)
                {
                    throw new Exception(BLOW_TYRE_ERROR_MESSAGE);
                }

                degradation = value;
            }
        }

        public override string Name => "Ultrasoft";

        public override void ReduceDegradation()
        {
            double sumOfHardnessAndGrip = this.Hardness + this.Grip; 

            this.Degradation -= sumOfHardnessAndGrip;
        }
    }
}
