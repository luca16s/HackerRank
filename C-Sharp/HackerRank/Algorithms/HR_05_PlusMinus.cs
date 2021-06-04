namespace HackerRank.Algorithms
{
    using System;
    using System.Collections.Generic;

    public class HR_05_PlusMinus
    {
        public static IEnumerable<string> PlusMinus(int n, string[] arrTemp)
        {
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);

            double positive = 0, negative = 0, zero = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positive++;
                if (arr[i] < 0)
                    negative++;
                if (arr[i] == 0)
                    zero++;
            }
            double totalPlus = positive / n;
            double totalMinus = negative / n;
            double totalZero = zero / n;

            yield return $"{totalPlus:0.000000}";
            yield return $"{totalMinus:0.000000}";
            yield return $"{totalZero:0.000000}";
        }
    }
}