using System;

namespace ReferenceTypes
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
            Console.WriteLine(DayOfBirth.ToShortDateString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InitializeAndModify();
            CopyAndModify();
        }

        private static void InitializeAndModify()
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
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person1 berefore Updating:");
            person1.Print();
            Console.WriteLine("Person2 berefore Updating:");
            person2.Print();

            person1.FirstName = "Teo ABC";
            person2.FirstName = "Ti XYZ";

            Console.WriteLine("Person1 after Updated:");
            person1.Print();
            Console.WriteLine("Person2 after Updated:");
            person2.Print();
        }

        private static void CopyAndModify()
        {
            Person person1 = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Person person2 = person1;

            Console.WriteLine("Person1 berefore Updating:");
            person1.Print();
            Console.WriteLine("Person2 berefore Updating:");
            person2.Print();

            person1.FirstName = "Teo ABC";
            person2.FirstName = "Ti XYZ";

            Console.WriteLine("Person1 after Updated:");
            person1.Print();
            Console.WriteLine("Person2 after Updated:");
            person2.Print();
        }
    }
}
