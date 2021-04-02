namespace DataAndYear.Controllers
{
    using System;

    public class Engine
    {
        public static void Run()
        {
            Console.Write("Enter a date: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            var Date = new Date(day, month, year);

            Console.Write("Add/Remove {number of days}: ");
            var arguments = Console.ReadLine().Split(' ');

            string command = arguments[0].ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        int daysToAdd = int.Parse(arguments[1]);
                        Date.Add(daysToAdd);
                        break;
                    case "remove":
                        int daysToRemove = int.Parse(arguments[1]);
                        Date.Remove(daysToRemove);
                        break;
                }

                Console.WriteLine($"Date: {Date.Day} Month: {Date.Month} Year: {Date.Year}");
                Console.Write("Add/Remove {number of days}: ");
                arguments = Console.ReadLine().Split(' ');
                command = arguments[0].ToLower();
            }
        }
    }
}
