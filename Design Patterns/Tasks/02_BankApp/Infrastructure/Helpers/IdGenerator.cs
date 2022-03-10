namespace _02_BankApp.Infrastructure.Helpers
{
    using System;

    public sealed class IdGenerator
    {
        private static long id;

        private IdGenerator()
        {

        }

        public string Id
        {
            get 
            {
                return id++.ToString().Substring(8); 
            }
        }

        public static IdGenerator Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
                id = DateTime.Now.Ticks;
            }

            internal static readonly IdGenerator instance = new IdGenerator();
        }
    }
}
