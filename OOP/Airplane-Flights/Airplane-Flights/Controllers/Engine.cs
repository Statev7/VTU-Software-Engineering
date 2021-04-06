namespace Airplane_Flights.Controllers
{

    using System;

    using System.Linq;

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
                        DraftManager.Create(arguments);
                        break;
                    case "search":
                        DraftManager.Search(arguments[0]);
                        break;
                }

                commnad = Console.ReadLine().ToLower();

            }
       }
    }
}
