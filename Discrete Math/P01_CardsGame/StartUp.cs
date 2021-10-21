namespace CardsGame
{
    using CardsGame.Core;
    using CardsGame.Core.Contracts;
    using CardsGame.IO;
    using CardsGame.IO.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
