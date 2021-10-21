namespace CardsGame.Models
{
    using System;

    using CardsGame.Models.Contracts;

    public class Casino : ICasino
    {
        private const int MIN_VALUE = 1;
        private const int MAX_VALUE = 4;

        private int[] firstPileOfCards;
        private int[] secondPileOfCards;
        private int[] thirdPileOfCards;
        private Random random;

        public Casino()
        {
            this.firstPileOfCards = new int[] { 1, 6, 8 };
            this.secondPileOfCards = new int[] { 2, 4, 9 };
            this.thirdPileOfCards = new int[] { 3, 5, 7 };
            this.random = new Random();
        }

        public void PlayGame(IPlayer firstPlayer, IPlayer seconPlayer, int gamesCount)
        {
            firstPlayer.PlayedGames = gamesCount;
            seconPlayer.PlayedGames = gamesCount;

            for (int i = 0; i < gamesCount; i++)
            {
                int firstPlayerPile = this.random.Next(MIN_VALUE, MAX_VALUE);

                int firstPlayerCard = this.random.Next(MIN_VALUE, MAX_VALUE) - 1;
                int secondPlayerCard = this.random.Next(MIN_VALUE, MAX_VALUE) - 1;

                if (firstPlayerPile == 1)
                {
                    firstPlayer.CurruntCard = firstPileOfCards[firstPlayerCard];
                    seconPlayer.CurruntCard = secondPileOfCards[secondPlayerCard];
                }
                else if (firstPlayerPile == 2)
                {
                    firstPlayer.CurruntCard = secondPileOfCards[firstPlayerCard];
                    seconPlayer.CurruntCard = thirdPileOfCards[secondPlayerCard];
                }
                else if(firstPlayerPile == 3)
                {
                    firstPlayer.CurruntCard = thirdPileOfCards[firstPlayerCard];
                    seconPlayer.CurruntCard = firstPileOfCards[secondPlayerCard];
                }

                if (firstPlayer.CurruntCard < seconPlayer.CurruntCard)
                {
                    seconPlayer.GamesWon++;
                }
                else
                {
                    firstPlayer.GamesWon++;
                }
            }
        }
    }
}
