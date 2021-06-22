using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregating
{
    class Program
    {
        static List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                IdNumber = "00000001",
                FirstName = "Ti",
                LastName = "Nguyen",
                Emails = new List<string>
                {
                    "tideptrai@gmail.com",
                    "conbahai@gmail.com"
                },
                CurrentSalary = 2500
            },
            new Employee
            {
                IdNumber = "00000002",
                FirstName = "Suu",
                LastName = "Nguyen",
                Emails = new List<string>
                {
                    "suu.nhi@gmail.com",
                    "tre.trau@gmail.com"
                },
                CurrentSalary = 2450
            }
            ,
            new Employee
            {
                IdNumber = "00000003",
                FirstName = "Dan",
                LastName = "Nguyen",
                Emails = new List<string>
                {
                    "ho.bao@gmail.com",
                },
                CurrentSalary = 5000
            }
        };

        static void Main(string[] args)
        {
            Console.WriteLine(Employees.Count(x => x.CurrentSalary > 3000));
            Console.WriteLine(Employees.Count(x => x.Emails.Count() > 1));
            Console.WriteLine(Employees.Min(x => x.CurrentSalary));
            Console.WriteLine(Employees.Max(x => x.CurrentSalary));
            Console.WriteLine(Employees.Average(x => x.CurrentSalary));
            Console.WriteLine(Employees.Sum(x => x.CurrentSalary));

            var specialEmployee = Employees.Aggregate((a, b) => new Employee
            {
                IdNumber = a.IdNumber + "," + b.IdNumber,
                FirstName = a.FirstName + "," + b.FirstName,
                LastName = a.LastName + "," + b.LastName,
                CurrentSalary = a.CurrentSalary + b.CurrentSalary,
                Emails = a.Emails.Concat(b.Emails).ToList(),
            });

            Console.WriteLine(specialEmployee);
        }
    }
}
