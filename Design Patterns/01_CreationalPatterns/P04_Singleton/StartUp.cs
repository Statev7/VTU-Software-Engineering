namespace P04_Singleton
{
    using System;

    using P04_Singleton.Models;

    public class StartUp
    {
        public static void Main()
        {  
            General general = General.GetInstance("Pesho", 37);

            General general1 = General.GetInstance("Gosho", 25);

            AddSoldiers(general, 1, 5);
            AddSoldiers(general1, 6, 10);

            Console.WriteLine($"{general} {Environment.NewLine}{string.Join(" ", general.Soldiers)}");
            Console.WriteLine($"{general1} {Environment.NewLine}{string.Join(" ", general.Soldiers)}");
        }

        private static void AddSoldiers(General general, int startIndex, int soldiersCount)
        {
            for (int i = startIndex; i <= soldiersCount; i++)
            {
                general.Add(new Soldier(i.ToString()));
            }
        }
    }
}
