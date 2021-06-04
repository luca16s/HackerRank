namespace HackerRank.Algorithms
{
    using System.Collections.Generic;

    public class HR_02_CompareTheTriplets
    {
        public static IEnumerable<int> CompareTheTriplets(int a0,
            int a1,
            int a2,
            int b0,
            int b1,
            int b2)
        {
            int pontoA = (a0 > b0 ? +1 : 0)
                + (a1 > b1 ? +1 : 0)
                + (a2 > b2 ? +1 : 0);

            int pontoB = (a0 < b0 ? +1 : 0)
                + (a1 < b1 ? +1 : 0)
                + (a2 < b2 ? +1 : 0);

            return new[] { pontoA, pontoB };
        }
    }
}