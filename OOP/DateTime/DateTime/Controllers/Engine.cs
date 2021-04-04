namespace DateTime.Controllers
{
    using System;

    public class Engine
    {
        public static void Run()
        {
            Console.Write("Въведете дата в следния формат: ден/месец/година: ");
            DateTime input = DateTime.Parse(Console.ReadLine());

            Date date = new Date { Day = input };

            Console.Write("Add/Remove {number of days}: ");
            var arguments = Console.ReadLine().Split(' ');
            string command = arguments[0].ToLower();

            while (command != "end")
            {
                
                switch (command)
                {
                    case "add":
                        int daysToAdd = int.Parse(arguments[1]);
                        date.AddDays(daysToAdd);
                        break;
                    case "remove":
                        int daysToRemove = int.Parse(arguments[1]);
                        date.RemoveDays(daysToRemove);
                        break;
                }

                Console.WriteLine($"{date.Day}");

                Console.Write("Add/Remove {number of days}: ");
                arguments = Console.ReadLine().Split(' ');
                command = arguments[0].ToLower();
            }
        }
    }
}
