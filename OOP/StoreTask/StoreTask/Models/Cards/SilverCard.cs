namespace StoreTask.Models.Cards
{
    using System;

    class SilverCard : BaseModel
    {
        private const double INITIAL_PERCENTAGE = 0.02;
        private const double PERCENTAGE_OVER_THREE_HUNDRED_TURNOVER = 0.035;

        public SilverCard(double turnover, double discount)
            : base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double procentDiscount = INITIAL_PERCENTAGE;

            if (base.Turnover > 300)
            {
                procentDiscount = PERCENTAGE_OVER_THREE_HUNDRED_TURNOVER;
            }

            return base.DiscountProcent(procentDiscount);
        }


    }
}
