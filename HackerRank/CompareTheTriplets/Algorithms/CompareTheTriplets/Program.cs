using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets.Algorithms.CompareTheTriplets
{
    internal static partial class Program
    {
        private static IEnumerable<int> Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            var pontoA = a0 > b0 ? +1 : a1 > b1 ? +1 : a2 > b2 ? +1 : +0;
            var pontoB = a0 < b0 ? +1 : a1 < b1 ? +1 : a2 < b2 ? +1 : +0;

            var total = new int[2] { pontoA, pontoB};
            return total;
        }

        private static void Main(string[] args)
        {
            var tokensA0 = Console.ReadLine().Split(' ');
            var a0 = Convert.ToInt32(tokensA0[0]);
            var a1 = Convert.ToInt32(tokensA0[1]);
            var a2 = Convert.ToInt32(tokensA0[2]);
            var tokensB0 = Console.ReadLine().Split(' ');
            var b0 = Convert.ToInt32(tokensB0[0]);
            var b1 = Convert.ToInt32(tokensB0[1]);
            var b2 = Convert.ToInt32(tokensB0[2]);
            var result = Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}