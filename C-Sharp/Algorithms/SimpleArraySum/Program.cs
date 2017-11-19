using System;
using System.Collections.Generic;

namespace SimpleArraySum
{
    internal static class Program
    {
        private static int SimpleArraySum(int n, IReadOnlyList<int> ar)
        {
            var total = 0;
            for (var i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }

        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arTemp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(arTemp, int.Parse);
            var result = SimpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}