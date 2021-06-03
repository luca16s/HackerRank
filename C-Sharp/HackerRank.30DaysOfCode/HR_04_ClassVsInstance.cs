namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;

    public class HR_04_ClassVsInstance
    {
        public static void ClassVsInstance()
        {
            int T = int.Parse(In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = ToInt32(In.ReadLine());
                var p = new Person(age);
                p.AmIOld();
                for (int j = 0; j < 3; j++)
                    p.YearPasses();
                p.AmIOld();
                WriteLine();
            }
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
                WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void AmIOld()
        {
            WriteLine("Teste");
            if (_age < 13)
            {
                WriteLine("You are young.");
            }
            else
            {
                if (_age is >= 13 and < 18)
                    WriteLine("You are a teenager.");
                else
                    WriteLine("You are old.");
            }
        }

        public void YearPasses()
        {
            _age++;
        }
    }
}