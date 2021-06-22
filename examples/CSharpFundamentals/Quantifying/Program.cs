using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifying
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
        }

        private static void Demo1()
        {
            IEnumerable<int> list = new List<int> { 2, 4, 6, 8, 10 };

            Console.WriteLine(list.Any(x => x % 2 == 0));

            Console.WriteLine(list.All(x => x % 2 == 0));

            Console.WriteLine(list.Contains(2));

            Console.WriteLine(list.Contains(5));
        }

        private static void Demo2()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 4, 6, 8, 10 };

            Console.WriteLine(list.Any(x => x % 2 == 0));

            Console.WriteLine(list.All(x => x % 2 == 0));

            Console.WriteLine(list.Contains(2));

            Console.WriteLine(list.Contains(5));
        }

        private static void Demo3()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 4, 6, 8, 10 };

            Console.WriteLine(list.Any(x => x % 2 == 0));

            Console.WriteLine(list.Where(x => x > 1).All(x => x % 2 == 0));

            Console.WriteLine(list.All(x => x > 1 && x % 2 == 0));

            Console.WriteLine(list.Where(x => x != 2).Contains(2));

            Console.WriteLine(list.Contains(5));
        }
    }
}
