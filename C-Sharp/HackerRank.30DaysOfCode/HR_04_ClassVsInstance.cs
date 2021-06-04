namespace HackerRank._30DaysOfCode
{
    using System.Collections.Generic;

    using static System.Convert;

    public class HR_04_ClassVsInstance
    {
        public static IEnumerable<string> ClassVsInstance(int timesToRepeat, int age)
        {
            for (int i = 0; i < timesToRepeat; i++)
            {
                var person = new Person(age);
                yield return person.AmIOld();
                for (int j = 0; j < 3; j++)
                    person.YearPasses();
                yield return person.AmIOld();
            }
        }
    }

    internal class Person
    {
        private int _age;

        public Person(int initialAge)
        {
            _age = initialAge > 0
                ? initialAge
                : 0;
        }

        public string Message { get; set; }

        public string AmIOld()
        {
            return _age < 13
                ? "You are young."
                : _age is >= 13 and < 18
                    ? "You are a teenager."
                    : "You are old.";
        }

        public void YearPasses()
        {
            _age++;
        }
    }
}