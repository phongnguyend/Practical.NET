using System;
using System.Collections.Generic;
using System.Linq;

namespace Joining
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
                CurrentCountryIsoCode = "VI"
            },
            new Customer
            {
                IdNumber = "00000002",
                FirstName = "Suu",
                LastName = "Nguyen",
                CurrentCountryIsoCode = "VI"
            },
            new Customer
            {
                IdNumber = "00000003",
                FirstName = "Dan",
                LastName = "Nguyen",
                CurrentCountryIsoCode = "VI"
            }
        };

        static List<Contact> Contacts = new List<Contact>
        {
            new Contact
            {
                CustomerIdNumber = "00000001",
                EmailAddress = "ti@gmail.com",
                PhoneNumber = "+84123456789",
                CountryIsoCode = "VI"
            },
            new Contact
            {
                CustomerIdNumber = "00000001",
                EmailAddress = "chuot@gmail.com",
                PhoneNumber = "+84123456790",
                CountryIsoCode = "US"
            },
            new Contact
            {
                CustomerIdNumber = "00000002",
                EmailAddress = "suu@gmail.com",
                PhoneNumber = "+84123456791",
                CountryIsoCode = "VI"
            }
        };

        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
        }

        static void Demo1()
        {
            var items = Customers.Join(Contacts,
                        customer => customer.IdNumber,
                        contact => contact.CustomerIdNumber,
                        (customer, contact) => new
                        {
                            Customer = customer,
                            Contact = contact,
                        });

            foreach (var item in items)
            {
                Console.WriteLine(item.Customer.ToString() + "\t" + item.Contact.ToString());
            }
        }

        static void Demo2()
        {
            var items = Customers.Join(Contacts,
                        customer => customer.IdNumber,
                        contact => contact.CustomerIdNumber,
                        (customer, contact) => new
                        {
                            customer.IdNumber,
                            customer.FirstName,
                            customer.LastName,
                            contact.EmailAddress,
                            contact.PhoneNumber,
                        });

            foreach (var item in items)
            {
                Console.WriteLine($"{item.IdNumber}\t{item.FirstName}\t{item.LastName}\t{ item.EmailAddress}\t{ item.PhoneNumber}");
            }
        }

        static void Demo3()
        {
            var items = Customers.Join(Contacts,
                        customer => new { customer.IdNumber, CountryIsoCode = customer.CurrentCountryIsoCode },
                        contact => new { IdNumber = contact.CustomerIdNumber, contact.CountryIsoCode },
                        (customer, contact) => new
                        {
                            Customer = customer,
                            Contact = contact,
                        });

            foreach (var item in items)
            {
                Console.WriteLine(item.Customer.ToString() + "\t" + item.Contact.ToString());
            }
        }

        static void Demo4()
        {
            var items = Customers.GroupJoin(Contacts,
                        customer => customer.IdNumber,
                        contact => contact.CustomerIdNumber,
                        (customer, contacts) => new
                        {
                            Customer = customer,
                            Contacts = contacts,
                        });

            foreach (var item in items)
            {
                Console.WriteLine(item.Customer.ToString());

                foreach (var contact in item.Contacts)
                {
                    Console.WriteLine("\t" + contact.ToString());
                }
            }
        }
    }
}
