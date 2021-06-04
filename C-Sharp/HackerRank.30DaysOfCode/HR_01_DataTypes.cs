namespace HackerRank._30DaysOfCode
{
    using System.Collections.Generic;

    public class HR_01_DataTypes
    {
        public static IEnumerable<string> DataTypes(int first, double second, string third)
        {
            const int i = 4;
            const double d = 4.0;
            const string s = "HackerRank ";

            yield return $"{ first + i}";
            yield return $"{second + d:0.0}";
            yield return s + third;
        }
    }
}