namespace P03_Composite
{
    using P03_Composite.Core;
    using P03_Composite.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
