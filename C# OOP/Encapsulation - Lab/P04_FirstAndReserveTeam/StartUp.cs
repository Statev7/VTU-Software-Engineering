namespace PersonsInfo
{

    using System;

    using PersonsInfo.Models;

    public class StartUp
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Team team = new Team("HALA MADRID");

            for (int i = 0; i < input; i++)
            {
                var arguments = Console.ReadLine().Split(' ');

                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                decimal salary = decimal.Parse(arguments[3]);

                Person person = new Person(firstName, lastName, age, salary);

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
