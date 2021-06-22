using System;

namespace BasicConceptsOfOOP
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DayOfBirth);
        }
    }

    class Customer : Person
    {
        public DateTime DateOfRegistration { get; set; }

        public override void Print()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(DateOfRegistration);
        }
    }

    class Employee : Person
    {
        public DateTime DateOfEmployment { get; set; }

        public override void Print()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DayOfBirth);
            Console.WriteLine(DateOfEmployment);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
