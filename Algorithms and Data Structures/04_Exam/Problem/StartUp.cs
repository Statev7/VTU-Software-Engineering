namespace Problem
{
    using System;

    public class StartUp
    {
        private const int N = 20;

        public static void Main()
        {
            Tree tree = new Tree();
            Node node = null;

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                int value = random.Next(10, 99);
                tree.AddNode(ref node, value);
            }

            Console.WriteLine($"Root: {node.key}");
            Console.WriteLine("Tree:");
            tree.Traverse(node);
            Console.WriteLine();

            var sum = tree.SumOfTree(node.left);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine(new string('-', 20));
            tree.FindElements(node.right, sum); // Намира по-малките елементи спрямо дадена сума.
            tree.DisplayQueue();
        }
    }
}
