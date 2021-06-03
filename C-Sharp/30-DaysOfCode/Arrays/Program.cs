namespace Arrays
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);
            for (int i = n - 1; i > -1; i--)
                if (arr.Length > i) Console.Write($"{arr[i]} ");
            Console.ReadLine();
        }
    }
}