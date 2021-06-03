namespace HackerRank.Algorithms
{
    using System.Collections.Generic;

    public class HR_03_AVeryBigSum
    {
        private static long VeryBigSum(int n, IReadOnlyList<long> ar)
        {
            long total = 0;
            for (int i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }
    }
}