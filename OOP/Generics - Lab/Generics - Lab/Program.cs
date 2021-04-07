namespace BoxOfT
{
    
    using System;

    using Models;

    public class Program
    {
        public static void Main()
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(2);

            box.Remove();
            Console.WriteLine(string.Join(" ", box));
        }

        
    }
}
