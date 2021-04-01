namespace DataAndYear
{

    using System;
    public class StartUp
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            Date date = new Date(day, month, year);

            date.Add(33);

            Console.WriteLine(date);
        }
    }
}
