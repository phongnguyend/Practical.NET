using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeAndModify();
            CopyAndModify();
        }

        private static void InitializeAndModify()
        {
            int x = 10;
            int y = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            x += 1;
            y -= 1;
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }

        private static void CopyAndModify()
        {
            int x = 10;
            int y = x;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            x += 1;
            y -= 1;
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
}
