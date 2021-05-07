namespace StoreTask.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using StoreTask.Models;

    public class PayDesk
    {

        public static void PrintResult(BaseModel model, double purchase)
        {
            double totalSum = purchase - model.Discount;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Discount value: {purchase:F2}");
            stringBuilder.AppendLine($"Discount rate: ");
            stringBuilder.AppendLine($"Discount {model.Discount:F2}");
            stringBuilder.AppendLine($"Total: {totalSum:F2}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
