﻿namespace HelloWorld
{
    using static System.Console;

    internal static class Program
    {
        private static void HelloWorld()
        {
            string inputString = ReadLine();

            WriteLine("Hello, World.");
            WriteLine(inputString);
        }

        private static void Main()
        {
            HelloWorld();
        }
    }
}