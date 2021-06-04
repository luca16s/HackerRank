namespace HackerRank._30DaysOfCode
{
    using System.Collections.Generic;

    public class HR_04_ClassVsInstance
    {
        public static IEnumerable<string> ClassVsInstance(int timesToRepeat, int[] age)
        {
            var messages = new List<string>();

            for (int i = 0; i < timesToRepeat; i++)
            {
                var person = new Person(age[i]);
                person.AmIOld();
                for (int j = 0; j < 3; j++)
                    person.YearPasses();
                person.AmIOld();

                messages.AddRange(person.Messages);
                messages.Add("");
            }

            return messages;
        }
    }

    internal class Person
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
                Messages.Add("Age is not valid, setting age to 0.");
            }
        }

        public List<string> Messages { get; private set; } = new List<string>();

        public void AmIOld()
        {
            Messages.Add(_age < 13
                ? "You are young."
                : _age is >= 13 and < 18
                ? "You are a teenager."
                : "You are old.");
        }

        public void YearPasses()
        {
            _age++;
        }
    }
}