using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtering
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
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            //Demo6();
            //Demo7();
            //Demo8();
            //Demo9();
            //Demo10();
            //Demo11();
            //Demo12();
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
            foreach (var customer in Customers)
            {
                if (customer.FirstName.StartsWith("T"))
                {
                    Console.WriteLine(customer);
                }
            }
        }

        private static void Demo3()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("T"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo4()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("T"))
                .Take(2);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo5()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("T"))
                .Skip(2)
                .Take(2);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void Demo6()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("T"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("First:");
            Console.WriteLine(customers.First());
            Console.WriteLine("Last:");
            Console.WriteLine(customers.Last());
        }

        private static void Demo7()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("Tt"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("First:");
            Console.WriteLine(customers.First());
            Console.WriteLine("Last:");
            Console.WriteLine(customers.Last());
        }

        private static void Demo8()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("Tt"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("First:");
            Console.WriteLine(customers.FirstOrDefault());
            Console.WriteLine("Last:");
            Console.WriteLine(customers.LastOrDefault());
        }

        private static void Demo9()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("T"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Single:");
            Console.WriteLine(customers.Single());
        }

        private static void Demo10()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("Ti"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Single:");
            Console.WriteLine(customers.Single());
        }

        private static void Demo11()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("Tt"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Single:");
            Console.WriteLine(customers.Single());
        }

        private static void Demo12()
        {
            var customers = Customers.Where(x => x.FirstName.StartsWith("Tt"));
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Single:");
            Console.WriteLine(customers.SingleOrDefault());
        }
    }
}
