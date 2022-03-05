using P04_Decorator.Models.Contracts;

namespace P04_Decorator.Models
{
    public class ElfBurgerDecorator : BaseBurgerDecorator
    {
        public ElfBurgerDecorator(IBurger burger) 
            : base(burger)
        {
        }

        public override string MakeBurger()
        {
            return base.MakeBurger() + this.AddCheese();
        }

        private string AddCheese()
        {
            return ", Cheese";
        }
    }
}
