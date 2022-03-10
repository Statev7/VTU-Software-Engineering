namespace _02_BankApp
{
    using _02_BankApp.Core;
    using _02_BankApp.Core.Contracts;
    using _02_BankApp.IO.Contracts;
    using _02_BankApp.IO.Readers;
    using _02_BankApp.IO.Writers;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
