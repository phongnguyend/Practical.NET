using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class PersonExtensions
    {
        public static void PrintFullName(this Person person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        public static void PrintFullName(this Person person, string additionalParam)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}
