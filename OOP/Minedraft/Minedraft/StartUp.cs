namespace Minedraft
{
    using System;

    using Minedraft.Models;
    public class StartUp
    {
        public static void Main()
        {
            HammerHarvester hammerHarvester = new HammerHarvester("dsa", 200, 10);
            Console.WriteLine(hammerHarvester);
        }
    }
}
