namespace StoreTask.Models.Cards
{
    using System;

    class SilverCard : BaseModel
    {
      
        public SilverCard(double turnover, double discount)
            : base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double discount = 0;

            if (base.Turnover <= 300)
            {
                discount = purchase * 0.02;
            }
            else
            {
                discount = purchase * 0.035;
            }

            return base.DiscountProcent(discount);
        }


    }
}
