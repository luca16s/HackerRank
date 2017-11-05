using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace BinaryNumbers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var binaries = new LinkedList<int>();
            var sequencia = new LinkedList<int>();
            Binarios(n, binaries, sequencia, 0);
            Console.WriteLine(Binarios(n, binaries, sequencia, 0).Item3);

            Console.ReadLine();
        }

        private static Tuple<int, int, int> Binarios(int number, LinkedList<int> binaries, LinkedList<int> sequencia, int count)
        {
            var divQuoc = 0;
            var maxValue = 0;
            while (true)
            {
                maxValue = sequencia.Concat(new[] {maxValue}).Max();

                if (number <= 0) return Tuple.Create(divQuoc, count, maxValue);
                var divRest = number % 2;
                binaries.AddFirst(divRest);
                divQuoc = number / 2;
                if (divRest == 1)
                {
                    count++;
                    sequencia.AddFirst(count);
                }
                else
                {
                    count = 0;
                }
                number = divQuoc;
            }
        }
    }
}
//5 - 5%2 =|2|1| - 2%2 = |1|0| - 1%2 = |0|1|
//6 - 6%2 =|3|0| - 3%2 = |1|1| - 1%2 = |0|1|
