namespace Helpers
{
    using System;

    public class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    public class Tree
    {
        // Метод за добавяне на възел на дърво

        public void AddNode(ref Node root, int value)
        {
            Node p = new Node();
            p.value = value;

            if (root == null)
            {
                root = p;
            }
            else
            {
                if (value < root.value)
                {
                    AddNode(ref root.left, value);
                }
                else if (value > root.value)
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

            Console.Write("{0} ", root.value); // Извежда стойността на текущият възел

            if (root.right != null) // Обхожда десните поддървета
            {
                Traverse(root.right);
            }
        }

        // КЛД обхождане
        public void TraverseKLD(Node root)
        {
            Console.Write("{0} ", root.value); // Извежда стойността на текущия възел

            if (root.left != null) // Обхожда левите поддървета
            {
                Traverse(root.left);
            }

            if (root.right != null) // Обхожда десните поддървета
            {
                Traverse(root.right);
            }
        }

        // Метод за търсене на елемент в дърво
        public bool Seacrh(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.value == value)
            {
                return true;
            }

            if (value < root.value)
            {
                return Seacrh(root.left, value);
            }
            else
            {
                return Seacrh(root.right, value);
            }
        }

        // Метод, който намира най-малкият елемент в дясното поддърво
        public Node FindMinRight(Node root)
        {
            Node p = root.right;

            while (p.left != null)
            {
                p = p.left; // Докато съществува ляв наследник премини към него
            }

            return p;
        }

        // Метод, който премахва елемент от дървото
        public void Remove(ref Node root, int value)
        {
            if (root == null)
            {
                Console.WriteLine("{0} is not in the tree", value);
            }
            else if (value < root.value)
            {
                Remove(ref root.left, value);
            }
            else if (value > root.value)
            {
                Remove(ref root.right, value);
            }
            else
            {
                if (root.left != null && root.right != null) // Ако елементът, който ще трия има 2 наследника
                {
                    Node replace = FindMinRight(root);
                    root.value = replace.value;

                    Remove(ref root.right, replace.value);
                }
                else
                {
                    Node temp = root;

                    if (root.left != null) // Ако елемнтът, който ще трия има ляв наследник минавам към него
                    {
                        root = root.left;
                    }
                    else
                    {
                        root = root.right;
                    }

                    temp = null;
                }
            }
        }
    }
}
