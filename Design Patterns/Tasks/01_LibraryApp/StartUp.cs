namespace _01_LibraryApp
{
    using _01_LibraryApp.Core;
    using _01_LibraryApp.Core.Contracts;
    using _01_LibraryApp.IO.Reader;
    using _01_LibraryApp.IO.Writer;

    public class StartUp
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
