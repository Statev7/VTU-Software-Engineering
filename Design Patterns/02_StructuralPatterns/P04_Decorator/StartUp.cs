namespace P04_Decorator
{
    using System;

    using P04_Decorator.Models;
    using P04_Decorator.Models.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IBurger burger = new PlainBurger();
            string plainBurgerResult = $"Plain burger: {burger.MakeBurger()}";
            Console.WriteLine(plainBurgerResult);
            Console.WriteLine(new string('-', 50));

            BaseBurgerDecorator beefBurgerDecorator = new BeefBurgerDecorator(burger);
            string beefBurgerDecoratorResult = $"Beef burger: {beefBurgerDecorator.MakeBurger()}";
            Console.WriteLine(beefBurgerDecoratorResult);
            Console.WriteLine(new string('-', 50));

            IBurger burger2 = new PlainBurger();
            BaseBurgerDecorator elfBurgerDecorator = new ElfBurgerDecorator(burger2);
            string elfBurgerDecoratorResult = $"Elf burger: {elfBurgerDecorator.MakeBurger()}";
            Console.WriteLine(elfBurgerDecoratorResult);

        }
    }
}
