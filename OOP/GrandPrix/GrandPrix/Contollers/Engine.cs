namespace GrandPrix.Contollers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        public static void Run()
        {
            var raceTower = new RaceTower();

            int numbersOfLaps = int.Parse(Console.ReadLine());
            int lengthOfTrack = int.Parse(Console.ReadLine());

            raceTower.SetTrackInfo(numbersOfLaps, lengthOfTrack); 

            string input = Console.ReadLine();
            string result = string.Empty;

            while (true)
            {
                List<string> arguments = input.Split(' ').ToList();

                string command = arguments[0];
                arguments = arguments.Skip(1).ToList();

                switch (command)
                {
                    case "RegisterDriver": raceTower.RegisterDriver(arguments); break;
                    case "Leaderboard": result = raceTower.GetLeaderboard(); break;
                    case "CompleteLaps": result = raceTower.CompleteLaps(arguments); break;
                    case "Box": raceTower.DriverBoxes(arguments); break;
                    case "ChangeWeather": raceTower.ChangeWeather(arguments); break;
                }

                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                    result = null;
                }

                if (raceTower.IsEndOfRace == true)
                {
                    Console.WriteLine($"{raceTower.Winner.Name} wins the race for {raceTower.Winner.TotalTime:F3} seconds.");
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
