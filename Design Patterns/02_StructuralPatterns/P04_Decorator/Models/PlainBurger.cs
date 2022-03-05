namespace P04_Decorator.Models
{
    using P04_Decorator.Models.Contracts;

    public class PlainBurger : IBurger
    {
        public string MakeBurger()
        {
            return "Bread, Meatballs";
        }
    }
}
