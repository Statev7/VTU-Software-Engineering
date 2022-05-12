namespace P01_Problem_1
{
    using System;
    using System.Collections.Generic;

    using Helpers;

    public class StartUp
    {
        private const int N = 20;
        private const int MIN_VALUE = 10;
        private const int MAX_VALUE = 99;

        public static void Main()
        {
            var tree = new Tree();
            Node root = null;

            CreateTree(tree, ref root);
            tree.Traverse(root);

            Console.WriteLine();
            Console.Write($"Enter a x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter a y: ");
            int y = int.Parse(Console.ReadLine());

            var result = new Stack<int>();
            FindTheNumbersInTheRange(root, x, y, result);
            PrintResult(result);
        }

        private static void CreateTree(Tree tree, ref Node root)
        {
            var random = new Random();

            for (int i = 0; i < N; i++)
            {
                var number = random.Next(MIN_VALUE, MAX_VALUE);

                bool isItemAlredyExist = tree.Seacrh(root, number);
                while (isItemAlredyExist)
                {
                    number = random.Next(10, 99);
                    isItemAlredyExist = tree.Seacrh(root, number);
                }

                tree.AddNode(ref root, number);
            }
        }

        private static void FindTheNumbersInTheRange(Node root, int x, int y, Stack<int> result)
        {
            var currentElement = root.value;
            if (currentElement >= x && currentElement <= y)
            {
                result.Push(currentElement);
            }

            if (root.left != null) 
            {
                FindTheNumbersInTheRange(root.left, x, y, result);
            }

            if (root.right != null) 
            {
                FindTheNumbersInTheRange(root.right, x, y, result);
            }
        }

        private static void PrintResult(Stack<int> result)
        {
            Console.WriteLine($"Stack: {string.Join(" ", result)}");
        }
    }
}
