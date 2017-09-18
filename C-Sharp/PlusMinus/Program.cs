using System;

namespace PlusMinus
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arrTemp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arrTemp, int.Parse);

            double positive = 0, negative = 0, zero = 0;
            for (var i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    positive = positive + 1;
                }
                if (arr[i] < 0)
                {
                    negative = negative + 1;
                }
                if (arr[i] == 0)
                {
                    zero = zero + 1;
                }
            }
            var totalPlus = positive / n;
            var totalMinus = negative / n;
            var totalZero = zero / n;
            Console.WriteLine(string.Format("{0:0.000000}", totalPlus));
            Console.WriteLine(string.Format("{0:0.000000}", totalMinus));
            Console.WriteLine(string.Format("{0:0.000000}", totalZero));
            Console.ReadLine();
        }
    }
}
