namespace P03_TowerOfHanoi
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int totalDisks = int.Parse(Console.ReadLine());
            SolveTowers(totalDisks, 'A', 'C', 'B');
        }

        private static void SolveTowers(int n, char fromRod, char toRod, char temp)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk from {fromRod} to {toRod}");
                return;
            }

            SolveTowers(n - 1, fromRod, temp, toRod);
            Console.WriteLine($"Move disk from {fromRod} to {toRod}");
            SolveTowers(n - 1, temp, toRod, fromRod);
        }
    }
}
