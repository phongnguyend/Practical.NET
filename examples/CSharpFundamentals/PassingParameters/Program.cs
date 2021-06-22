///
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters
///

using System;

namespace PassingParameters
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
            Demo1();
            Demo2();
            Demo3();
            Demo4();
            Demo5();
            Demo6();
        }

        private static void Demo1()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");

            UpdateX(x);

            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateX(int x)
        {
            Console.WriteLine($"x = {x}");
            x += 1;
            Console.WriteLine($"x = {x}");
        }

        private static void Demo2()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");

            UpdateXUsingRef(ref x);
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateXUsingRef(ref int x)
        {
            Console.WriteLine($"x = {x}");
            x += 1;
            Console.WriteLine($"x = {x}");
        }

        private static void Demo3()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");

            UpdateXUsingOut(out x);
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateXUsingOut(out int x)
        {
            //Console.WriteLine($"x = {x}");
            x = 1;
            x += 1;
            Console.WriteLine($"x = {x}");
        }


        private static void Demo4()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            UpdatePerson(person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void UpdatePerson(Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            person.FirstName = "Teo ABC";
        }

        private static void Demo5()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            OverridePerson(person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void OverridePerson(Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            person = new Person
            {
                FirstName = "Teo ABC",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };
        }

        private static void Demo6()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            UpdatePersonUsingRef(ref person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void UpdatePersonUsingRef(ref Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            //person.FirstName = "Teo ABC";

            person = new Person
            {
                FirstName = "Teo ABC",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };
        }
    }
}
