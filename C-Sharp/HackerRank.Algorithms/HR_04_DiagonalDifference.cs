namespace HackerRank.Algorithms
{
    using System;

    using static System.Math;

    public class HR_04_DiagonalDifference
    {
        public static int DiagonalDifference(int n, string[][] aTemp)
        {
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = Array.ConvertAll(aTemp[i], int.Parse);
            }

            int diagonalOne = 0;
            int diagonalTwo = 0;

            int coluna = array[0].Length;
            for (int linha = 0; linha < n; linha++)
            {
                coluna--;
                diagonalOne += array[linha][linha];
                diagonalTwo += array[linha][coluna];
            }

            return Abs(diagonalOne - diagonalTwo);
        }
    }
}