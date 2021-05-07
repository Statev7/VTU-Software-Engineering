namespace StoreTask.Models.Cards
{
    public class GoldCard : BaseModel
    {
        public GoldCard(double turnover, double discount)
           : base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double discount = 0.02;

            if (base.Turnover > 800)
            {
                discount = purchase * 0.1;
            }
            else
            {
                discount = discount + base.Turnover / 1000;
            }
            
            return base.DiscountProcent(discount);
        }
    }
}
