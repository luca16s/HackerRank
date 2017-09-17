using System;

namespace AVeryBigSum
{
    static class Program
    {
        static long AVeryBigSum(int n, long[] ar)
        {
            // Complete this function
        }

        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arTemp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(arTemp, Int64.Parse);
            var result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
