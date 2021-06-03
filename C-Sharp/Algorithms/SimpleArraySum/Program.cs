namespace SimpleArraySum
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        private static int SimpleArraySum(int n, IReadOnlyList<int> ar)
        {
            int total = 0;
            for (int i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }

        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arTemp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(arTemp, int.Parse);
            int result = SimpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}