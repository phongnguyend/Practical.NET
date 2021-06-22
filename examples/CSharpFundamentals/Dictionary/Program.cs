using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            //Demo6();
            //Demo7();
        }

        private static void Demo1()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[1] = "One";
            dictionary[2] = "Two";
            dictionary[3] = "Three";
            dictionary.Add(4, "Four");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[4]);

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
                Console.WriteLine($"Key: {keyValue.Key}, Value: {dictionary[keyValue.Key]}");
            }
        }

        private static void Demo2()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                [1] = "One",
                [2] = "Two",
                [3] = "Three"
            };
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[4]);

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
                Console.WriteLine($"Key: {keyValue.Key}, Value: {dictionary[keyValue.Key]}");
            }
        }

        private static void Demo3()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                [1] = "One",
                [2] = "Two",
                [3] = "Three"
            };
            dictionary.Add(4, "Four");
            dictionary.Add(4, "Four");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[4]);

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
                Console.WriteLine($"Key: {keyValue.Key}, Value: {dictionary[keyValue.Key]}");
            }
        }

        private static void Demo4()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                [1] = "One",
                [2] = "Two",
                [3] = "Three",
                [4] = "Four"
            };

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[4]);
            Console.WriteLine(dictionary[5]);
            Console.WriteLine(dictionary.ContainsKey(5) ? dictionary[5] : "NotFound");

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
                Console.WriteLine($"Key: {keyValue.Key}, Value: {dictionary[keyValue.Key]}");
            }
        }

        private static void Demo5()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                ["VN"] = "Việt Nam",
                ["US"] = "United States",
                ["UK"] = "United Kingdom",
            };

            Console.WriteLine(dictionary["VN"]);
            Console.WriteLine(dictionary["US"]);
            Console.WriteLine(dictionary["UK"]);

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
                Console.WriteLine($"Key: {keyValue.Key}, Value: {dictionary[keyValue.Key]}");
            }
        }

        private static void Demo6()
        {
            List<Person> people = new List<Person>
            {
                new Person {Id = "000001", FirstName = "Ti" },
                new Person {Id = "000005", FirstName = "Teo" },
            };

            foreach (var person in people)
            {
                if (person.Id == "000001")
                {
                    person.Print();
                    break;
                }
            }
        }

        private static void Demo7()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>
            {
                ["000001"] = new Person { FirstName = "Ti" },
                ["000005"] = new Person { FirstName = "Teo" },
            };

            var foundPerson = people["000001"];
            foundPerson.Print();
        }
    }
}
