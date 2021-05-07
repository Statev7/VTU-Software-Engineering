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
            double discount = purchase * model.Discount;
            double totalSum = purchase - (purchase * model.Discount);
            

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Purchase value: ${purchase:F2}");
            stringBuilder.AppendLine($"Discount rate: {model.Discount * 100:F1}%");
            stringBuilder.AppendLine($"Discount ${discount:F2}");
            stringBuilder.AppendLine($"Total: ${totalSum:F2}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
