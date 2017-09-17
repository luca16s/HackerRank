using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using static System.Convert;


namespace DataTypes
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var i = 4;
            var d = 4.0;
            var s = "HackerRank ";

            // Declare second integer, double, and String variables.
            var first = 0;
            var second = 0.0;
            // Read and save an integer, double, and String to your variables.
            first = ToInt32(ReadLine());
            second = ToDouble(ReadLine());
            var third = ReadLine();
            // Print the sum of both integer variables on a new line.

            WriteLine(first+i);
            // Print the sum of the double variables on a new line.
            WriteLine(string.Format("{0:0.0}", second + d));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            WriteLine(s+third);
            ReadLine();
        }
    }
}
