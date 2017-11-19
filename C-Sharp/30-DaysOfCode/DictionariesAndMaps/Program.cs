using System;
using System.Collections.Generic;

namespace DictionariesAndMaps
{
    internal static class Program
    {
        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();
            for (var i = 0; i < n; i++)
            {
                var list = Console.ReadLine();
                var start = list.IndexOf(" ", StringComparison.Ordinal);
                var end = list.LastIndexOf(" ", StringComparison.Ordinal);
                Console.WriteLine(start);
                Console.WriteLine(end);
                var lenght = start - 1;
                var total = list.Length;
                phoneBook.Add(list.Substring(0, lenght+1), list.Substring(lenght+1, total-(lenght+1)).Replace(" ", ""));
            }
            for (var i = 0; i < n; i++)
            {
                var escolha = Console.ReadLine();
                Console.WriteLine(phoneBook.ContainsKey(escolha) ? escolha + "=" + phoneBook[escolha] : "Not found");
            }
            Console.ReadLine();
        }
    }
}
