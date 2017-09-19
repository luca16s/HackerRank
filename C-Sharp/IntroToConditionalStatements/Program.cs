using System;

namespace IntroToConditionalStatements
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            if (n%2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (n >= 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else
                {
                    if (n >= 6 && n <= 20)
                    {
                        Console.WriteLine("Weird");
                    }
                    else
                    {
                        if (n >= 20)
                        {
                            Console.WriteLine("Not Weird");
                        }
                    }
                }
            }
        }
    }
}
