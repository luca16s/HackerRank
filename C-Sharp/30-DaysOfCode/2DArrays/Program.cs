﻿namespace _2DArrays
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int[][] arr = new int[6][];
            for (int arrI = 0; arrI < 6; arrI++)
            {
                string[] arrTemp = Console.ReadLine().Split(' ');
                arr[arrI] = Array.ConvertAll(arrTemp, int.Parse);
            }
        }
    }
}