namespace CompareTheTriplets.Algorithms.CompareTheTriplets
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        private static IEnumerable<int> Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int pontoA = (a0 > b0 ? +1 : 0) + (a1 > b1 ? +1 : 0) + (a2 > b2 ? +1 : 0);
            int pontoB = (a0 < b0 ? +1 : 0) + (a1 < b1 ? +1 : 0) + (a2 < b2 ? +1 : 0);

            int[] total = new[] {pontoA, pontoB};
            return total;
        }

        private static void Main()
        {
            string[] tokensA0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokensA0[0]);
            int a1 = Convert.ToInt32(tokensA0[1]);
            int a2 = Convert.ToInt32(tokensA0[2]);
            string[] tokensB0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokensB0[0]);
            int b1 = Convert.ToInt32(tokensB0[1]);
            int b2 = Convert.ToInt32(tokensB0[2]);
            IEnumerable<int> result = Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}