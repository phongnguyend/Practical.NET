using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public class Person
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
}
