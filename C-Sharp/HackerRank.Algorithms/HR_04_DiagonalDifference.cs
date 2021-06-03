namespace HackerRank.Algorithms
{
    using System;

    using static System.Math;

    public class HR_04_DiagonalDifference
    {
        public static void DiagonalDifference(int n, string[] aTemp)
        {
            int[][] a = new int[n][];
            for (int aI = 0; aI < n; aI++)
            {
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

            Console.WriteLine(Abs(diagonalOne - diagonalTwo));
        }
    }
}