using System;
using System.Collections.Generic;
using System.Linq;

namespace Flattening
{
    class Program
    {
        static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                IdNumber = "00000001",
                FirstName = "Ti",
                LastName = "Nguyen",
                Emails = new List<string>
                {
                    "tideptrai@gmail.com",
                    "conbahai@gmail.com"
                }
            },
            new Customer
            {
                IdNumber = "00000002",
                FirstName = "Suu",
                LastName = "Nguyen",
                Emails = new List<string>
                {
                    "suu.nhi@gmail.com",
                    "tre.trau@gmail.com"
                }
            }
        };

        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
        }

        static void Demo1()
        {
            var listOfListEmails = Customers.Select(x => x.Emails);

            foreach (var listOfEmails in listOfListEmails)
            {
                foreach (var email in listOfEmails)
                {
                    Console.WriteLine(email);
                }
            }
        }

        private static void Demo2()
        {
            var listOfEmails = Customers.SelectMany(x => x.Emails);

            foreach (var email in listOfEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
