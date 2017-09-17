using System;

namespace Satircase
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var controle = 1;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < controle; j++)
                {
                    Console.Write("#");
                }
                controle = controle + 1;
                Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
