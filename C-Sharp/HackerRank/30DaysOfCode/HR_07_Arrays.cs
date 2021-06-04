namespace HackerRank._30DaysOfCode
{
    using System;

    public class HR_07_Arrays
    {
        public static string ArraysMethod(int n, string arrTemp)
        {
            string result = string.Empty;

            int[] arr = Array.ConvertAll(arrTemp.Split(" "), int.Parse);
            for (int i = n - 1; i > -1; i--)
                if (arr.Length > i)
                    result += $"{arr[i]} ";

            return result;
        }
    }
}