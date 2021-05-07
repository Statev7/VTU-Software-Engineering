namespace StoreTask.Models
{
    using System;

    public abstract class BaseModel
    {
        private double turnover;
        private double discount;

        public BaseModel(double turnover, double discount)
        {
            this.turnover = turnover;
            this.discount = discount;
        }

        public string Owner { get; private set; }

        public double Turnover
        {
            get
            {
                return this.turnover;
            }
            set
            {
                this.turnover = value;
            }
        }

        public double Discount 
        { 
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }

        public virtual double DiscountProcent(double procentDiscount)
        {
            return procentDiscount;
        }

    }
}
