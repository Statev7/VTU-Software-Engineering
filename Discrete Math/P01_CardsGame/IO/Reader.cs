namespace CardsGame.IO
{
    using System;

    using CardsGame.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
