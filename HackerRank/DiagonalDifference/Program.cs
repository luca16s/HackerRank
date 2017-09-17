using System;

namespace DiagonalDifference
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var a = new int[n][];
            for (var aI = 0; aI < n; aI++)
            {
                var aTemp = Console.ReadLine().Split(' ');
                a[aI] = Array.ConvertAll(aTemp, int.Parse);
            }
        }
    }
}
