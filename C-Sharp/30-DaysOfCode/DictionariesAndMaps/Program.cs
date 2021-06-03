namespace DictionariesAndMaps
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string list = Console.ReadLine();
                int start = list.IndexOf(" ", StringComparison.Ordinal);
                int end = list.LastIndexOf(" ", StringComparison.Ordinal);
                Console.WriteLine(start);
                Console.WriteLine(end);
                int lenght = start - 1;
                int total = list.Length;
                phoneBook.Add(list.Substring(0, lenght + 1),
                    list.Substring(lenght + 1, total - (lenght + 1)).Replace(" ", ""));
            }
            for (int i = 0; i < n; i++)
            {
                string escolha = Console.ReadLine();
                Console.WriteLine(phoneBook.ContainsKey(escolha) ? escolha + "=" + phoneBook[escolha] : "Not found");
            }
            Console.ReadLine();
        }
    }
}