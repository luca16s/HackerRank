namespace LetsReview
{
    using System;
    using System.Collections;

    internal static class Program
    {
        private static void Main()
        {
            int quant;
            Console.WriteLine("Insira a quantidade de palavras:");
            quant = Convert.ToInt32(Console.ReadLine());
            string wordOne = null;
            string wordTwo = null;
            for (int i = 0; i < quant; i++)
            {
                string word = Console.ReadLine();
                var wordSeparated = new ArrayList();
                for (int j = 0; j < word.Length; j++)
                {
                    wordSeparated.Add(word.Substring(j, 1));
                    if (j % 2 == 0)
                        wordOne = wordOne + wordSeparated[j];
                    else
                        wordTwo = wordTwo + wordSeparated[j];
                }
                Console.WriteLine(wordOne + " " + wordTwo);
                wordOne = null;
                wordTwo = null;
            }
            Console.ReadLine();
        }
    }
}