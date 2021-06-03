﻿namespace PlusMinus
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);

            double positive = 0, negative = 0, zero = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positive = positive + 1;
                if (arr[i] < 0)
                    negative = negative + 1;
                if (arr[i] == 0)
                    zero = zero + 1;
            }
            double totalPlus = positive / n;
            double totalMinus = negative / n;
            double totalZero = zero / n;
            Console.WriteLine(string.Format("{0:0.000000}", totalPlus));
            Console.WriteLine(string.Format("{0:0.000000}", totalMinus));
            Console.WriteLine(string.Format("{0:0.000000}", totalZero));
            Console.ReadLine();
        }
    }
}