using System;
using System.Collections.Generic;
using System.Linq;

namespace QuerySyntax
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
            },
            new Customer
            {
                IdNumber = "00000002",
                FirstName = "Suu",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000003",
                FirstName = "Dan",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000004",
                FirstName = "Mao",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000005",
                FirstName = "Thin",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000006",
                FirstName = "Ty",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000007",
                FirstName = "Ngo",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000008",
                FirstName = "Mui",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000009",
                FirstName = "Than",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000010",
                FirstName = "Dau",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000011",
                FirstName = "Tuat",
                LastName = "Nguyen",
            },
            new Customer
            {
                IdNumber = "00000012",
                FirstName = "Hoi",
                LastName = "Nguyen",
            },
        };

        static void Main(string[] args)
        {
            Demo3();
            //Demo4();
        }

        private static void Demo3()
        {
            //var customers = Customers.Where(x => x.FirstName.StartsWith("T"));
            var customers = from c in Customers
                            where c.FirstName.StartsWith("T")
                            select c;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo4()
        {
            //var customers = Customers.Where(x => x.FirstName.StartsWith("T"))
            //    .Take(2);
            var customers = (from c in Customers
                             where c.FirstName.StartsWith("T")
                             select c).Take(2);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
