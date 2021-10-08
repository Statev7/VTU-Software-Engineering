namespace P01_Person
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());

            Child child = new Child(name, age);
            Console.WriteLine(child);

        }
    }
}
