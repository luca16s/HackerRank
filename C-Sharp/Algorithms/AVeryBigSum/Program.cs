using System;
using System.Collections.Generic;

namespace AVeryBigSum
{
    public static class Program
    {
        private static long AVeryBigSum(int n, IReadOnlyList<long> ar)
        {
            // Complete this function
            long total = 0;
            for (var i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }

        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arTemp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(arTemp, long.Parse);
            var result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}