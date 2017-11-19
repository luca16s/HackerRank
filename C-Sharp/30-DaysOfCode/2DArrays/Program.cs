using System;

namespace _2DArrays
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var arr = new int[6][];
            for (var arrI = 0; arrI < 6; arrI++)
            {
                var arrTemp = Console.ReadLine().Split(' ');
                arr[arrI] = Array.ConvertAll(arrTemp, int.Parse);
            }
        }
    }
}
