namespace HackerRank.Algorithms
{
    using System.Collections.Generic;

    public class HR_06_Staircase
    {
        public static IEnumerable<string> Staircase(int n)
        {
            for (int i = 0; i < n; i++)
                yield return new string('#', i + 1).PadLeft(n, ' ');
        }
    }
}