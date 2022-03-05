namespace P04_Decorator.Models
{
    using P04_Decorator.Models.Contracts;

    public abstract class BaseBurgerDecorator : IBurger
    {
        protected IBurger burger;

        protected BaseBurgerDecorator(IBurger burger)
        {
            this.burger = burger;
        }

        public virtual string MakeBurger()
        {
           return this.burger.MakeBurger();
        }
    }
}
