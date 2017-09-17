using System;

namespace SolveMeFirst
{
    internal static class Program
    {
        private static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }

        private static void Main(string[] args)
        {
            var val1 = Convert.ToInt32(Console.ReadLine());
            var val2 = Convert.ToInt32(Console.ReadLine());
            var sum = SolveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
