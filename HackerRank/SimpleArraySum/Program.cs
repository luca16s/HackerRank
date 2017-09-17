using System;

namespace SimpleArraySum
{
    internal static class Program
    {
        private static int SimpleArraySum(int n, int[] ar)
        {
            var total = 0;
            for (var i = 0; i < n; i++)
            {
                total = ar[i] + total;
            }
            return total;
        }

        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arTemp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(arTemp, Int32.Parse);
            var result = SimpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}
