namespace CardsGame.Models.Contracts
{
    public interface ICasino
    {
        void PlayGame(IPlayer firstPlayer, IPlayer secondPlayer, int gamesCount);
    }
}
