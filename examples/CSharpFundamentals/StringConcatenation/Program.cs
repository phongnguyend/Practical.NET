using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rookies";
            int year = 2021;
            string greeting = "Hello " + name + " " + year + "!";
            string greeting2 = "Hello ";
            greeting2 += name;
            greeting2 += " ";
            greeting2 += year + "!";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine("Hello " + name + " " + year + "!");
            Console.WriteLine(string.Concat("Hello ", name, " ", year, "!"));
            Console.WriteLine($"Hello {name} {year}!");
        }
    }
}
