using System;

namespace Arrays
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arrTemp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arrTemp, int.Parse);
            for (var i = n - 1; i > -1; i--)
            {
                if (arr.Length > i) Console.Write($"{arr[i]} ");
            }
            Console.ReadLine();
        }
    }
}
