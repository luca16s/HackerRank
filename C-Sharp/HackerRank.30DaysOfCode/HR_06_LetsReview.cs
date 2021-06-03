namespace HackerRank._30DaysOfCode
{
    using System.Collections;

    using static System.Console;
    using static System.Convert;

    public class HR_06_LetsReview
    {
        public static void LetsReview()
        {
            int quant;
            WriteLine("Insira a quantidade de palavras: ");
            quant = ToInt32(ReadLine());
            string wordOne = null;
            string wordTwo = null;
            for (int i = 0; i < quant; i++)
            {
                string word = ReadLine();
                var wordSeparated = new ArrayList();
                for (int j = 0; j < word.Length; j++)
                {
                    _ = wordSeparated.Add(word.Substring(j, 1));
                    if (j % 2 == 0)
                        wordOne += wordSeparated[j];
                    else
                        wordTwo += wordSeparated[j];
                }
                WriteLine(wordOne + " " + wordTwo);
                wordOne = null;
                wordTwo = null;
            }
            _ = ReadLine();
        }
    }
}