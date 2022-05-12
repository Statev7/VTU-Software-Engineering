namespace P03_Problem_3
{
    using System;
    using System.Collections.Generic;

    using Helpers;

    public class StartUp
    {
        private const int N = 30;
        private const int MIN_VALUE = 100;
        private const int MAX_VALUE = 999;

        public static void Main()
        {
            var linkedList = new LinkedList<int>();

            CreateLinkedList(linkedList);
            Console.WriteLine(string.Join(" ", linkedList));

            Tree tree = new Tree();
            Node root = null;

            CreateTree(linkedList, tree, ref root);
            tree.TraverseKLD(root);
        }

        private static void CreateTree(LinkedList<int> linkedList, Tree tree, ref Node root)
        {
            var node = linkedList.First;
            while (node != null)
            {
                var currentNumber = node.Value;
                if (currentNumber % 10 == 7)
                {
                    tree.AddNode(ref root, node.Value);
                }
                node = node.Next;
            }
        }

        private static void CreateLinkedList(LinkedList<int> linkedList)
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                var number = random.Next(MIN_VALUE, MAX_VALUE);
                bool isPrime = Algorithms.CheckIfNumberIsPrime(number);
                while (!isPrime)
                {
                    number = random.Next(MIN_VALUE, MAX_VALUE);
                    isPrime = Algorithms.CheckIfNumberIsPrime(number);
                }

                linkedList.AddFirst(number);
            }
        }
    }
}
