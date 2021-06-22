using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2021, 8, 13).AddDays(0);

            Console.WriteLine("Discount: {0}", date.GetDiscount());
            Console.WriteLine("Discount1: {0}", date.GetDiscount1());
            Console.WriteLine("Discount2: {0}", date.GetDiscount2());
            Console.WriteLine("Discount3: {0}", date.GetDiscount3());
            Console.ReadLine();
        }
    }
}
