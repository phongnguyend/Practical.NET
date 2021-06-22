using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"x = y: {x == y}");
            Console.WriteLine($"x != y: {x != y}");
            Console.WriteLine($"x > y: {x > y}");
            Console.WriteLine($"x < y: {x < y}");
            Console.WriteLine($"x >= y: {x >= y}");
            Console.WriteLine($"x <= y: {x <= y}");
        }
    }
}
