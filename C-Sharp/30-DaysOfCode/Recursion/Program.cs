﻿namespace Recursion
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int Factorial(int n)
        {
            int counter = n - 1;
            int result = n;
            if (n != 1)
                result = Factorial(counter) * result;
            return result;
        }
    }
}