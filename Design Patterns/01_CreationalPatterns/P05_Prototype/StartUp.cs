namespace P05_Prototype
{
    using P05_Prototype.Core;
    using P05_Prototype.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
