using System;

namespace Loops
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < 11; i++)
            {
                var result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
        }
    }
}
