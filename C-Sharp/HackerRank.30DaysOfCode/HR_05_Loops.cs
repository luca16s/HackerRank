namespace HackerRank._30DaysOfCode
{
    using System.Collections.Generic;

    public class HR_05_Loops
    {
        public static IEnumerable<string> Loops(int n)
        {
            for (int i = 1; i < 11; i++)
            {
                int result = n * i;
                yield return $"{n} x {i} = {result}";
            }
        }
    }
}