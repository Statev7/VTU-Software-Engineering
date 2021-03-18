namespace GrandPrix.Models
{
    using System;
    public abstract class Tyre
    {
        private const double MIN_DEGRADATION = 0;
        private const string BLOW_TYRE_ERROR_MESSAGE = "Blown Tyre";

        private double degradation;
        protected Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation = 100;
        }
        public abstract string Name { get; }
        public double Hardness { get; set; }
        public virtual double Degradation
        {
            get
            {
                return degradation;
            }
            set
            {
                bool isInvalid = this.degradation < MIN_DEGRADATION;

                if (isInvalid)
                {
                    throw new Exception(BLOW_TYRE_ERROR_MESSAGE);
                }

                degradation = value;
            }
        }

        public virtual void ReduceDegradation()
        {
            this.Degradation -= this.Hardness;
        }


    }
}
