namespace AVeryBigSum
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        private static long AVeryBigSum(int n, IReadOnlyList<long> ar)
        {
            // Complete this function
            long total = 0;
            for (int i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arTemp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(arTemp, long.Parse);
            long result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}