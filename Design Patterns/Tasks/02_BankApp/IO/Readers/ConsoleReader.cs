namespace _02_BankApp.IO.Readers
{
    using System;

    using _02_BankApp.IO.Contracts;

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
