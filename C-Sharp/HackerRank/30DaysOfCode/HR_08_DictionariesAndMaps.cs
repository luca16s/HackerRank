namespace HackerRank._30DaysOfCode
{
    using System;
    using System.Collections.Generic;

    public class HR_08_DictionariesAndMaps
    {
        public static IEnumerable<string> DictionariesAndMaps(int count,
            string[] list,
            string[] escolha)
        {
            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                int start = list[i].IndexOf(" ", StringComparison.Ordinal);
                int lenght = start - 1;
                int total = list[i].Length;
                phoneBook
                    .Add(list[i].Substring(0, lenght + 1),
                    list[i][(lenght + 1)..total].Replace(" ", ""));
            }
            for (int i = 0; i < count; i++)
            {
                yield return phoneBook.ContainsKey(escolha[i])
                    ? $"{escolha[i]}={phoneBook[escolha[i]]}"
                    : "Not found";
            }
        }
    }
}