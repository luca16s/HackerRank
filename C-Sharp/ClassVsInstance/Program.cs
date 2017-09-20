using System;

namespace ClassVsInstance
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var T = int.Parse(Console.In.ReadLine());
            for (var i = 0; i < T; i++)
            {
                var age = int.Parse(Console.In.ReadLine());
                var p = new Person(age);
                p.AmIOld();
                for (var j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
                Console.WriteLine();
            }
        }

        private class Person
        {
            private int _age;
            public Person(int initialAge)
            {
                if (initialAge > 0)
                {
                    _age = initialAge;
                }
                else
                {
                    _age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }
            }

            public void AmIOld()
            {
                Console.WriteLine("Teste");
                if (_age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else
                {
                    if (_age >= 13 && _age < 18)
                    {
                        Console.WriteLine("You are a teenager.");
                    }
                    else
                    {
                        Console.WriteLine("You are old.");
                    }
                }
            }

            public void YearPasses() => _age++;
        }
    }
}
