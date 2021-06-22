using System;

namespace Types
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }
    }

    class Company
    {
        public string Name { get; set; }

        public string Website { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(i.GetType());
            Console.WriteLine(typeof(int));

            string text = "abc";
            Console.WriteLine(text.GetType());
            Console.WriteLine(typeof(string));

            bool b = false;
            Console.WriteLine(b.GetType());
            Console.WriteLine(typeof(bool));

            Person person1 = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };
            Console.WriteLine(person1.GetType());
            Console.WriteLine(typeof(Person));

            Company nashtech = new Company
            {
                Name = "NashTech Vietnam",
                Website = "https://nashtechglobal.com/"
            };
            Console.WriteLine(nashtech.GetType());
            Console.WriteLine(typeof(Company));
        }
    }
}
