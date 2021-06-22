using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x = {x}");

            //x += 5;
            x = x + 5;
            Console.WriteLine($"x += 5 => x = {x}");

            //x -= 3;
            x = x - 3;
            Console.WriteLine($"x -= 3 => x = {x}");

            //x *= 2;
            x = x * 2;
            Console.WriteLine($"x *= 2 => x = {x}");

            //x /= 2;
            x = x / 2;
            Console.WriteLine($"x /= 2 => x = {x}");

            //x %= 5;
            x = x % 5;
            Console.WriteLine($"x %= 5 => x = {x}");
        }
    }
}
