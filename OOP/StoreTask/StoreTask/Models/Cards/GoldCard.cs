namespace StoreTask.Models.Cards
{
    public class GoldCard : BaseModel
    {
        private const double INITIAL_PERCENTAGE = 0.02;
        private const double MAX_PERCENTAGE = 0.1;

        public GoldCard(double turnover, double discount)
           : base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double procentDiscount = INITIAL_PERCENTAGE;

            if (base.Turnover > 800)
            {
                procentDiscount = MAX_PERCENTAGE;
            }
            else
            {
                procentDiscount = procentDiscount + base.Turnover / 1000;
            }
            
            return procentDiscount;
        }
    }
}
