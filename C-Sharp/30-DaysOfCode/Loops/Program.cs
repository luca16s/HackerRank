namespace Loops
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                int result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
        }
    }
}