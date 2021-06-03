namespace HackerRank.Algorithms
{
    using System.Collections.Generic;

    public class HR_06_Starcase
    {
        public static IEnumerable<string> Starcase(int n)
        {
            for (int i = 0; i < n; i++)
                yield return new string('#', i + 1).PadLeft(n, ' ');
        }
    }
}