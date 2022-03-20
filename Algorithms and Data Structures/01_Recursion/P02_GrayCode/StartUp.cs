namespace P02_GrayCode
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = GenerateGrayCode(n);
            Console.WriteLine(result);
        }

        private static string GenerateGrayCode(int n)
        {
            if (n == 1)
            {
                return $"{n}";
            }

            return $"{GenerateGrayCode(n - 1)}, {n}, {GenerateGrayCode(n - 1)}";
        }
    }
}
