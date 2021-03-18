namespace GrandPrix.Models.Cars
{
    using System;
    public class Car
    {
        private const double MIN_CAPACITY = 0;
        private const double MAXIMUM_CAPACITY = 160;
        private const string DRIVER_CANNOT_CONTINUE_ERROR_MESSAGE = "Out  of fuel";

        private double fuelAmount;

        public Car(int hp, double fullAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fullAmount;
            this.Tyre = tyre;
        }

        public int Hp { get; set; }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                bool isInvalid = value < MIN_CAPACITY;

                if (value > MAXIMUM_CAPACITY)
                {
                    value = 160;
                }


                if (isInvalid)
                {
                    throw new ArgumentException(DRIVER_CANNOT_CONTINUE_ERROR_MESSAGE);
                }

                fuelAmount = value;
            }
        }
        public Tyre Tyre { get; set; }

        public void ReduceFuel(int trackLenght, double fuelConsumption)
        {
            this.FuelAmount -= trackLenght * fuelConsumption; 
        }
        public void Refuel(double fuel)
        {
            this.FuelAmount += fuel;
        }

        public void ChangeTyre(Tyre newTyre)
        {
            this.Tyre = newTyre;
        }
    }
}
