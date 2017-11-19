using System;

namespace Satircase
{
    internal static class Program
    {
        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
            Console.ReadLine();
        }
    }
}