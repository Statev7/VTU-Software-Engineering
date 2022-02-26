namespace P01_Adapter
{
    using P01_Adapter.Core;
    using P01_Adapter.Core.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
