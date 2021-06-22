using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            person.PrintFullName();
            PersonExtensions.PrintFullName(person);
        }
    }
}
