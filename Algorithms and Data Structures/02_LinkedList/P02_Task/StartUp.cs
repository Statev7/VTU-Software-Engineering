namespace P02_Task
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 100;
        private const int RANDOM_NUMBERS_COUNT = 30;

        private const string INVALID_ARGUMENTS_ERROR_MESSAGE = "X cannot be greater than or equal to y!";

        private static LinkedList<int> linkedList = new LinkedList<int>();
        private static int x;
        private static int y;

        public static void Main()
        {
            GenerateData();
            PrintCollection(linkedList);
            Console.WriteLine(new string('-', 100));

            ReadInput();
            ValidateInput();
            Console.WriteLine(new string('-', 100));

            DeleteElements();
            PrintCollection(linkedList);
            Console.WriteLine(new string('-', 100));

            var result = ItemsThatAreDividedWithoutResidue();
            PrintCollection(result);
        }

        private static void GenerateData()
        {
            var random = new Random();

            for (int i = 0; i < RANDOM_NUMBERS_COUNT; i++)
            {
                var value = random.Next(MIN_VALUE, MAX_VALUE);
                linkedList.AddFirst(value);
            }
        }

        private static void ReadInput()
        {
            Console.Write("Enter a x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter a y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void ValidateInput()
        {
            while (x >= y)
            {
                Console.WriteLine(INVALID_ARGUMENTS_ERROR_MESSAGE);
                Console.Write("Enter a new x: ");
                x = int.Parse(Console.ReadLine());
            }
        }

        private static void DeleteElements()
        {
            var node = linkedList.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value >= x && node.Value <= y)
                {
                    linkedList.Remove(node);
                }

                node = nextNode;
            }
        }

        private static int[] ItemsThatAreDividedWithoutResidue()
        {
            var node = linkedList.First;
            var list = new List<int>();

            while (node != null)
            {
                var nextNode = node.Next;

                bool isValid = node.Value % x == 0 || node.Value % y == 0;
                if (isValid)
                {
                    list.Add(node.Value);
                }

                node = nextNode;
            }

            return list.ToArray();
        }

        private static void PrintCollection(ICollection<int> collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
