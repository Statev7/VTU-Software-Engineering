namespace Helpers
{
    using System;

    public static class Algorithms
    {
        public static bool CheckIfNumberIsPrime(int value)
        {
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
