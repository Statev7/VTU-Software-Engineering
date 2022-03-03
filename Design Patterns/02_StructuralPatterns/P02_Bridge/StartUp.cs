namespace P02_Bridge
{
    using P02_Bridge.Core;
    using P02_Bridge.Core.Contacts;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
