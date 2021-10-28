namespace CardsGame.Models
{
    using System;

    using CardsGame.Models.Contracts;

    public class Casino : ICasino
    {
        private const int MIN_PILE_VALUE = 1;
        private const int MAX_PILE_VALUE = 4;
        private const int MIN_CARD_POSITION = 0;
        private const int MAX_CARD_POSITION = 3;

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
                int firstPlayerPile = this.random.Next(MIN_PILE_VALUE, MAX_PILE_VALUE);

                int firstPlayerCardPosition = this.random.Next(MIN_CARD_POSITION, MAX_CARD_POSITION);
                int secondPlayerCardPosition = this.random.Next(MIN_CARD_POSITION, MAX_CARD_POSITION);

                if (firstPlayerPile == 1)
                {
                    firstPlayer.CurruntCard = firstPileOfCards[firstPlayerCardPosition];
                    seconPlayer.CurruntCard = secondPileOfCards[secondPlayerCardPosition];
                }
                else if (firstPlayerPile == 2)
                {
                    firstPlayer.CurruntCard = secondPileOfCards[firstPlayerCardPosition];
                    seconPlayer.CurruntCard = thirdPileOfCards[secondPlayerCardPosition];
                }
                else if(firstPlayerPile == 3)
                {
                    firstPlayer.CurruntCard = thirdPileOfCards[firstPlayerCardPosition];
                    seconPlayer.CurruntCard = firstPileOfCards[secondPlayerCardPosition];
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
