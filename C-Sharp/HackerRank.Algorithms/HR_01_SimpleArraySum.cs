namespace HackerRank.Algorithms
{
    using System.Collections.Generic;

    public class HR_01_SimpleArraySum
    {
        private static int SimpleArraySum(int n, IReadOnlyList<int> ar)
        {
            int total = 0;
            for (int i = 0; i < n; i++)
                total = ar[i] + total;
            return total;
        }
    }
}