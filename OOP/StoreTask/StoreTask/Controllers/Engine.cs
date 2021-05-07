namespace StoreTask.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using StoreTask.Models;
    using StoreTask.Models.Cards;

    class Engine
    {
        public static void Run()
        {
            var arguments = Console.ReadLine().Split(' ').ToList();

            string card = arguments[0];

            BaseModel baseModel = null;

            double turnover = double.Parse(arguments[4]);
            double purchase = double.Parse(arguments[7]);

            switch (card)
            {
                case "Bronze:":
                    baseModel = new BronzeCard(turnover, purchase);
                    break;
                case "Silver:":
                    baseModel = new SilverCard(turnover, purchase);
                    break;
                case "Gold:":
                    baseModel = new GoldCard(turnover, purchase);
                    break;
            }

            PayDesk.PrintResult(baseModel, purchase);
        }
    }
}
