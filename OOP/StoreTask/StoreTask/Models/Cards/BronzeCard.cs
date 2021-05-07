namespace StoreTask.Models.Cards
{

    public class BronzeCard : BaseModel
    {

        public BronzeCard(double turnover, double discount)
            :base(turnover, discount)
        {
            this.Discount = DiscountProcent(discount);
        }

        public override double DiscountProcent(double purchase)
        {
            double discount = 0;

            if (base.Turnover >= 100 || base.Turnover <= 300)
            {
                discount = Turnover * 0.01;
            }
            else if (base.Turnover > 300)
            {
                discount = Turnover * 0.025;
            }

            return base.DiscountProcent(discount);  
        }
    }
}
