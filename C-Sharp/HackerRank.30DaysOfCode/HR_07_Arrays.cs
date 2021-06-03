namespace HackerRank._30DaysOfCode
{
    using System;

    using static System.Console;
    using static System.Convert;

    public class HR_07_Arrays
    {
        public static void ArraysMethod()
        {
            int n = ToInt32(ReadLine());
            string[] arrTemp = ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);
            for (int i = n - 1; i > -1; i--)
                if (arr.Length > i) Write($"{arr[i]} ");
            _ = ReadLine();
        }
    }
}