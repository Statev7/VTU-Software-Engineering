namespace CardsGame.Core
{
    using CardsGame.Core.Contracts;
    using CardsGame.IO.Contracts;
    using CardsGame.Models;
    using CardsGame.Models.Contracts;

    public class Engine : IEngine
    {
        private const int MIN_GAMES_VALUE = 1;
        private const string INPUT_MESSAGE = "Enter the number of games: ";
        private const string INVALID_GAMES_COUNT_MESSAGE = "Invalid number of games. Please enter a new number: ";

        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            ICasino casino = new Casino();

            IPlayer firstPlayer = new Player();
            IPlayer secondPlayer = new Player();

            writer.Write(INPUT_MESSAGE);
            int gamesCount = int.Parse(reader.ReadLine());
            while (gamesCount < MIN_GAMES_VALUE)
            {
                writer.Write(INVALID_GAMES_COUNT_MESSAGE);
                gamesCount = int.Parse(reader.ReadLine());
            }

            casino.PlayGame(firstPlayer, secondPlayer, gamesCount);

            writer.WriteLine(secondPlayer.ToString());
        }
    }
}
