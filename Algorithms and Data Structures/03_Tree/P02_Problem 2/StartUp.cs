namespace P02_Problem_2
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Helpers;

    public class StartUp
    {
        private const int N = 30;

        public static void Main()
        {
            var array = new int[N];

            CreateArray(array);
            Print(array, "Array before:");

            var tree = new Tree();
            Node root = null;
            CreateTree(array, tree, ref root);

            int startIndex = 0;
            Traverse(root, array, ref startIndex);
            Print(array, "Array after:");
        }

        private static void CreateArray(int[] array)
        {
            var random = new Random();

            for (int index = 0; index < N; index++)
            {
                var number = random.Next(10, 99);
                var isElementAlreadyExist = array.Any(x => x == number);
                while (isElementAlreadyExist)
                {
                    number = random.Next(10, 99);
                    isElementAlreadyExist = array.Any(x => x == number);
                }

                array[index] = number;
            }
        }

        private static void CreateTree(int[] array, Tree tree, ref Node root)
        {
            for (int index = 0; index < N; index++)
            {
                var currentElement = array[index];
                tree.AddNode(ref root, currentElement);
            }
        }

        private static void Traverse(Node root, int[] array, ref int index)
        {
            if (root.left != null) 
            {
                Traverse(root.left, array, ref index);
            }

            array[index++] = root.value;

            if (root.right != null) 
            {
                Traverse(root.right, array, ref index);
            }
        }

        private static void Print(ICollection<int> collection, string message)
        {
            string result = $"{message} {string.Join(" ", collection)}";
            Console.WriteLine(result);
        }

    }
}
