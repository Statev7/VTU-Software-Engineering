namespace CardsGame.Models
{
    using System.Text;

    using CardsGame.Models.Contracts;

    public class Player : IPlayer
    {
        public int CurruntCard { get; set; }

        public int GamesWon { get; set; }

        public int PlayedGames { get; set; }

        public double Procent => (double)this.GamesWon /(double)this.PlayedGames;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Played games: {this.PlayedGames}");
            sb.AppendLine($"Games won: {this.GamesWon}");
            sb.AppendLine($"Percentage: {this.Procent}");

            return sb.ToString();
        }
    }
}
