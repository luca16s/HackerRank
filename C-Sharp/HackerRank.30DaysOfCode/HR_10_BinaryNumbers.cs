namespace HackerRank._30DaysOfCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static System.Console;
    using static System.Convert;

    public class HR_10_BinaryNumbers
    {
        public static void BinaryNumbers()
        {
            int n = ToInt32(ReadLine());
            var binaries = new LinkedList<int>();
            var sequencia = new LinkedList<int>();
            _ = Binarios(n, binaries, sequencia, 0);
            WriteLine(Binarios(n, binaries, sequencia, 0).Item3);

            _ = ReadLine();
        }

        private static Tuple<int, int, int> Binarios(int number,
            LinkedList<int> binaries,
            LinkedList<int> sequencia,
            int count)
        {
            int divQuoc = 0;
            int maxValue = 0;
            while (true)
            {
                maxValue = sequencia.Concat(new[] { maxValue }).Max();

                if (number <= 0) return Tuple.Create(divQuoc, count, maxValue);
                int divRest = number % 2;
                _ = binaries.AddFirst(divRest);
                divQuoc = number / 2;
                if (divRest == 1)
                {
                    count++;
                    _ = sequencia.AddFirst(count);
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