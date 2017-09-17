using System;

namespace AVeryBigSum
{
    static class Program
    {
        private static long AVeryBigSum(int n, long[] ar)
        {
            // Complete this function
            long total = 0;
            for (var i = 0; i < n; i++)
            {
                total = ar[i] + total;
            }
            return total;
        }

        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arTemp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(arTemp, Int64.Parse);
            var result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
