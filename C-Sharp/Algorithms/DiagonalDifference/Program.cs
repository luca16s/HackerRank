using System;

namespace DiagonalDifference
{
    internal static class Program
    {
        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var a = new int[n][];
            for (var aI = 0; aI < n; aI++)
            {
                var aTemp = Console.ReadLine().Split(' ');
                a[aI] = Array.ConvertAll(aTemp, int.Parse);
            }
            var diagonalOne = 0;
            var diagonalTwo = 0;

            for (var i = 0; i < n; i++)
                diagonalOne = a[i][i] + diagonalOne;
            for (var i = 0; i < n; i++)
            for (var j = n - 1; j != -1; j--)
            {
                diagonalTwo = a[i][j] + diagonalTwo;
                i = i + 1;
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