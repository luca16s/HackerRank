namespace HackerRank._30DaysOfCode
{
    using System;

    using static System.Console;

    public class HR_11_2DArrays
    {
        public static void TwoDArrays()
        {
            int[][] arr = new int[6][];
            for (int arrI = 0; arrI < 6; arrI++)
            {
                string[] arrTemp = ReadLine().Split(' ');
                arr[arrI] = Array.ConvertAll(arrTemp, int.Parse);
            }
        }
    }
}