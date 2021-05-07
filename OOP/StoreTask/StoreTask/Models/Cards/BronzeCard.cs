namespace StoreTask.Models.Cards
{

    public class BronzeCard : BaseModel
    {
        private const double INITIAL_PERCENTAGE = 0;
        private const double PERCENTAGE_BETWEEN_ONE_HUNDRED_AND_THREE_HUNDRED_TURNOVER = 0.01;
        private const double PERCENTAGE_OVER_THREE_HUNDRED_TURNOVER = 0.025;

        public BronzeCard(double turnover, double discount)
            :base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double procentDiscount = INITIAL_PERCENTAGE;

            if (base.Turnover >= 100 && base.Turnover <= 300)
            {
                procentDiscount = PERCENTAGE_BETWEEN_ONE_HUNDRED_AND_THREE_HUNDRED_TURNOVER;
            }
            else if (base.Turnover > 300)
            {
                procentDiscount = PERCENTAGE_OVER_THREE_HUNDRED_TURNOVER;
            }

            return base.DiscountProcent(procentDiscount);  
        }
    }
}
