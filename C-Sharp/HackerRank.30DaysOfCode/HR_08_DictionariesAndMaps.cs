namespace HackerRank._30DaysOfCode
{
    using System;
    using System.Collections.Generic;

    using static System.Console;
    using static System.Convert;

    public class HR_08_DictionariesAndMaps
    {
        public static void DictionariesAndMaps()
        {
            int n = ToInt32(ReadLine());
            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string list = ReadLine();
                int start = list.IndexOf(" ", StringComparison.Ordinal);
                int end = list.LastIndexOf(" ", StringComparison.Ordinal);
                WriteLine(start);
                WriteLine(end);
                int lenght = start - 1;
                int total = list.Length;
                phoneBook
                    .Add(list.Substring(0, lenght + 1),
                    list[(lenght + 1)..total].Replace(" ", ""));
            }
            for (int i = 0; i < n; i++)
            {
                string escolha = ReadLine();
                WriteLine(phoneBook.ContainsKey(escolha)
                    ? escolha + "=" + phoneBook[escolha]
                    : "Not found");
            }
            _ = ReadLine();
        }
    }
}