using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryNumbers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var binaries = new LinkedList<int>();
            Binarios(n, binaries, 0);
            Console.WriteLine(Binarios(n, binaries, 0).Item2);

            Console.ReadLine();
        }

        private static (int, int) Binarios(int number, LinkedList<int> binaries, int count)
        {
            var divQuoc = 0;
            if (number > 0)
            {
                var divRest = number % 2;
                binaries.AddFirst(divRest);
                divQuoc = number / 2;
                if (divRest != 0) count++;
                if (divRest == 0) count--;
                return Binarios(divQuoc, binaries, count);
            }
            return (divQuoc, count);
        }
    }
}
//5 - 5%2 =|2|1| - 2%2 = |1|0| - 1%2 = |0|1|
