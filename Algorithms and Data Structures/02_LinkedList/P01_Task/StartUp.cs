namespace P01_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private const int NEW_ELEMENT = 10;

        private static LinkedList<int> linkedList = new LinkedList<int>();
        private static LinkedListNode<int> lastEqualNode;

        public static void Main()
        {
            ReadData();
            PrintSeparator();
            PrintList();

            PrintSeparator();
            Console.Write("Enter a x: ");
            int x = int.Parse(Console.ReadLine());

            var node = linkedList.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value > x)
                {
                    linkedList.Remove(node);
                }
                else if (node.Value == x)
                {
                    lastEqualNode = node;
                }

                node = nextNode;
            }

            bool isNotNull = lastEqualNode != null;
            if (isNotNull)
            {
                linkedList.AddAfter(lastEqualNode, NEW_ELEMENT);
            }

            PrintSeparator();
            PrintList();
        }

        private static void ReadData()
        {
            Console.Write("Enter a input: ");

            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int index = 0; index < input.Length; index++)
            {
                int value = input[index];
                linkedList.AddLast(value);
            }
        }

        private static void PrintList()
        {
            Console.WriteLine(string.Join(" ", linkedList));
        }

        private static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 20));
        }
    }
}
