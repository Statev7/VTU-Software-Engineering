namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var personArgm = Console.ReadLine().Split();
                var person = new Person(personArgm[0],
                                        personArgm[1], 
                                        byte.Parse(personArgm[2]), 
                                        decimal.Parse(personArgm[3]));

                persons.Add(person);
            }

            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
