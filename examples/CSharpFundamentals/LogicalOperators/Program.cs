using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"x > 1 and y > 1: {x > 1 && y > 1}");
            Console.WriteLine($"x > 1 and y < 1: {x > 1 && y < 1}");
            Console.WriteLine($"x < 1 and y > 1: {x < 1 && y > 1}");
            Console.WriteLine($"x < 1 and y < 1: {x < 1 && y < 1}");

            Console.WriteLine($"x > 1 or y > 1: {x > 1 || y > 1}");
            Console.WriteLine($"x > 1 or y < 1: {x > 1 || y < 1}");
            Console.WriteLine($"x < 1 or y > 1: {x < 1 || y > 1}");
            Console.WriteLine($"x < 1 or y < 1: {x < 1 || y < 1}");
        }
    }
}
