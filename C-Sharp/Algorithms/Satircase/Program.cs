namespace Satircase
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
            Console.ReadLine();
        }
    }
}