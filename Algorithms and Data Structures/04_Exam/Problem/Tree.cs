namespace Problem
{
    using System;
    using System.Collections.Generic;

    public class Tree
    {
        private Queue<int> queue = new Queue<int>();

        public void AddNode(ref Node root, int value)
        {
            Node p = new Node();
            p.key = value;

            if (root == null)
            {
                root = p;
            }
            else
            {
                if (value < root.key)
                {
                    AddNode(ref root.left, value);
                }
                else if (value > root.key)
                {
                    AddNode(ref root.right, value);
                }
                else
                {
                    Console.WriteLine("{0} is already in the tree", value);
                }
            }
        }

        // ЛКД обхождане 
        public void Traverse(Node root)
        {
            if (root.left != null) // Обхожда левите поддърета
            {
                Traverse(root.left);
            }

            Console.Write("{0} ", root.key); // Извежда стойността на текущият възел

            if (root.right != null) // Обхожда десните поддървета
            {
                Traverse(root.right);
            }
        }

        public int SumOfTree(Node node)
        {
            bool isNull = node == null;
            if (isNull)
            {
                return 0;
            }

            return node.key + SumOfTree(node.left) + SumOfTree(node.right);
        }

        public void FindElements(Node node, int sum)
        {
            if (node.key < sum)
            {
                this.queue.Enqueue(node.key);
            }

            if (node.left != null)
            {
                FindElements(node.left, sum);
            }

            if (node.right != null)
            {
                FindElements(node.right, sum);
            }
        }

        public void DisplayQueue()
        {
            string resultAsString = $"Queue: {string.Join(" ", this.queue)}";
            Console.WriteLine(resultAsString);
        }
    }
}
