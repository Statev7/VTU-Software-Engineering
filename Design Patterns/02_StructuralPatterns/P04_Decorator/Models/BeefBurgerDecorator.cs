using P04_Decorator.Models.Contracts;

namespace P04_Decorator.Models
{
    public class BeefBurgerDecorator : BaseBurgerDecorator
    {
        public BeefBurgerDecorator(IBurger burger) 
            : base(burger)
        {
        }

        public override string MakeBurger()
        {
            return base.MakeBurger() + this.AddExtraMeatBall() + this.AddOnion();
        }

        private string AddExtraMeatBall()
        {
            return ", MeatBall";
        }

        private string AddOnion()
        {
            return ", Onion";
        }
    }
}
