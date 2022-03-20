namespace P01_Fibonacci
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);
            Console.WriteLine(result);
        }

        private static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
