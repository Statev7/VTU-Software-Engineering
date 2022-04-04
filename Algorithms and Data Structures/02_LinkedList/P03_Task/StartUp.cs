namespace P03_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static LinkedList<int> A = new LinkedList<int>();
        private static LinkedList<int> B = new LinkedList<int>();
        private static LinkedList<int> C = new LinkedList<int>();

        public static void Main()
        {
            Console.WriteLine("First list input");
            ReadDate(A);

            Console.WriteLine("Second list input");
            ReadDate(B);

            MergeLists(A);
            MergeLists(B);

            var result = C.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", result));
        }

        private static void ReadDate(LinkedList<int> list)
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                list.AddFirst(number);

                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
            }
        }

        private static void MergeLists(LinkedList<int> list)
        {
            var node = list.First;
            while (node != null)
            {
                var nextNode = node.Next;
                C.AddFirst(node.Value);

                node = nextNode;
            }
        }
    }
}
