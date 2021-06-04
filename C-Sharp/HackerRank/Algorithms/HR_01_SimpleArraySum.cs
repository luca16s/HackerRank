namespace HackerRank.Algorithms
{
    public class HR_01_SimpleArraySum
    {
        public static int SimpleArraySum(int n, int[] array)
        {
            int total = 0;
            for (int i = 0; i < n; i++)
                total = array[i] + total;
            return total;
        }
    }
}