namespace HackerRank._30DaysOfCode
{
    using System.Collections;
    using System.Collections.Generic;

    public class HR_06_LetsReview
    {
        public static IEnumerable<string> LetsReview(int quant, string[] wordList)
        {
            for (int i = 0; i < quant; i++)
            {
                string wordOne = null;
                string wordTwo = null;

                var wordSeparated = new ArrayList();
                for (int j = 0; j < wordList[i].Length; j++)
                {
                    _ = wordSeparated.Add(wordList[i].Substring(j, 1));
                    if (j % 2 == 0)
                        wordOne += wordSeparated[j];
                    else
                        wordTwo += wordSeparated[j];
                }
                yield return $"{wordOne} {wordTwo}";
            }
        }
    }
}