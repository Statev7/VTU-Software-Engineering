namespace CardsGame.Models.Contracts
{
    public interface IPlayer
    {
        public int CurruntCard { get; set; }

        public int GamesWon { get; set; }

        public int PlayedGames { get; set; }

        public double Procent { get; }
    }
}
