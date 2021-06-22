using System;

namespace ClassesAndObjects
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public void Print()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DayOfBirth);
        }
    }

    class Company
    {
        public string Name { get; set; }

        public string Website { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Website);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Person person2 = new Person
            {
                FirstName = "Ti",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1990, 1, 1)
            };

            Console.WriteLine("Person1:");
            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person1.LastName);
            Console.WriteLine(person1.DayOfBirth);

            Console.WriteLine("Person2:");
            Console.WriteLine(person2.FirstName);
            Console.WriteLine(person2.LastName);
            Console.WriteLine(person2.DayOfBirth);

            Company nashtech = new Company
            {
                Name = "NashTech Vietnam",
                Website = "https://nashtechglobal.com/"
            };

            Company sony = new Company
            {
                Name = "Sony Vietnam",
                Website = "https://www.sony.com.vn/"
            };

            Console.WriteLine("Company1:");
            Console.WriteLine(nashtech.Name);
            Console.WriteLine(nashtech.Website);
            nashtech.Print();

            Console.WriteLine("Company2:");
            Console.WriteLine(sony.Name);
            Console.WriteLine(sony.Website);
            sony.Print();
        }
    }
}
