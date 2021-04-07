namespace Airplane_Flights.Controllers
{
    using System;
    using System.Linq;

    using Airplane_Flights.Models;

    public class Engine
    {
       public static void Run()
       {
            string commnad = Console.ReadLine().ToLower();

            while (commnad != "exit")
            {
                var arguments = Console.ReadLine().Split(' ').ToList();

                arguments = arguments.Skip(1).ToList();

                switch (commnad)
                {
                    case "create":
                        Planes.Create(arguments);
                        break;
                    case "search":
                        Planes.Search(arguments[0]);
                        break;
                }

                commnad = Console.ReadLine().ToLower();

            }
       }
    }
}
