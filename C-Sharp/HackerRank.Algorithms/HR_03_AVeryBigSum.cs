namespace HackerRank.Algorithms
{
    public class HR_03_AVeryBigSum
    {
        public static long VeryBigSum(int n, long[] array)
        {
            long total = 0;
            for (int i = 0; i < n; i++)
                total = array[i] + total;
            return total;
        }
    }
}