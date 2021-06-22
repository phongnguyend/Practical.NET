using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordering
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
            new Customer
            {
                IdNumber = "00000013",
                FirstName = "Ti",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000014",
                FirstName = "Suu",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000015",
                FirstName = "Dan",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000016",
                FirstName = "Mao",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000017",
                FirstName = "Thin",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000018",
                FirstName = "Ty",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000019",
                FirstName = "Ngo",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000020",
                FirstName = "Mui",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000021",
                FirstName = "Than",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000022",
                FirstName = "Dau",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000023",
                FirstName = "Tuat",
                LastName = "Tran",
            },
            new Customer
            {
                IdNumber = "00000024",
                FirstName = "Hoi",
                LastName = "Tran",
            },
        };

        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
        }

        private static void Demo1()
        {
            foreach (var customer in Customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo2()
        {
            var customers = Customers.OrderBy(x => x.FirstName);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo3()
        {
            var customers = Customers.OrderByDescending(x => x.FirstName);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo4()
        {
            var customers = Customers.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
