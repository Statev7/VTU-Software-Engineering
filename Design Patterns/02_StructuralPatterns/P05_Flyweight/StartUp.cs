namespace P05_Flyweight
{
    using P05_Flyweight.Core;
    using P05_Flyweight.Core.Contracts;

    class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
