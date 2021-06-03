﻿namespace DiagonalDifference
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int aI = 0; aI < n; aI++)
            {
                string[] aTemp = Console.ReadLine().Split(' ');
                a[aI] = Array.ConvertAll(aTemp, int.Parse);
            }
            int diagonalOne = 0;
            int diagonalTwo = 0;

            for (int i = 0; i < n; i++)
                diagonalOne = a[i][i] + diagonalOne;
            for (int i = 0; i < n; i++)
                for (int j = n - 1; j != -1; j--)
                {
                    diagonalTwo = a[i][j] + diagonalTwo;
                    i++;
                }
            //Console.WriteLine(diagonalOne);
            //Console.WriteLine(diagonalTwo);
            Console.WriteLine(Math.Abs(diagonalOne - diagonalTwo));
            //Console.ReadLine();
            //  1A - 1 - 1C 00 - 02
            //  1 - 1B - 1  11 - 11
            //  1A - 1 - 1C 22 - 20
        }
    }
}