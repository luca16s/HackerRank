namespace ArrayDS
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        public static List<int> ReverseArray(List<int> a)
        {
            var listaArray = new List<int>();

            for (int i = a.Count - 1; i >= 0; i--)
            {
                listaArray.Add(a[i]);
            }
            return listaArray;
        }

        private static void Main()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            var arr = Console
                .ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            List<int> res = ReverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}