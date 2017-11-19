using System;

namespace Recursion
{
    internal static class Program
    {
        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var result = Factorial(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int Factorial(int n)
        {
            var counter = n - 1;
            var result = n;
            if (n != 1)
            {
                result = Factorial(counter) * result;
            }
            return result;
        }
    }
}
