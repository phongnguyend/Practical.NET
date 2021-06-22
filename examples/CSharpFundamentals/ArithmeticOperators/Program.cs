using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoAddition();
            //DemoSubtraction();
            //DemoMultiplication();
            //DemoDivision();
            //DemoModulus();
            //DemoIncrement();
            //DemoDecrement();
        }

        /// <summary>
        /// Adds together two values
        /// </summary>
        static void DemoAddition()
        {
            int x = 1;
            int y = 2;
            int z = x + y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = x + y = {z}");
            Console.WriteLine($"x + y = {x + y}");
            Console.WriteLine($"y + x = {y + x}");
        }

        /// <summary>
        /// Subtracts one value from another
        /// </summary>
        static void DemoSubtraction()
        {
            int x = 1;
            int y = 2;
            int z = x - y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = x - y = {z}");
            Console.WriteLine($"x - y = {x - y}");
            Console.WriteLine($"y - x = {y - x}");
        }

        /// <summary>
        /// Multiplies two values
        /// </summary>
        static void DemoMultiplication()
        {
            int x = 2;
            int y = 3;
            int z = x * y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = x * y = {z}");
            Console.WriteLine($"x * y = {x * y}");
            Console.WriteLine($"y * x = {y * x}");
        }

        /// <summary>
        /// Divides one value by another
        /// </summary>
        static void DemoDivision()
        {
            //int x = 2;
            //int y = 3;
            //int z = x / y;

            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"y = {y}");
            //Console.WriteLine($"z = x / y = {z}");
            //Console.WriteLine($"x / y = {x / y}");
            //Console.WriteLine($"y / x = {y / x}");

            int x = 2;
            int y = 3;
            float z = x / (float)y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = x / y = {z}");
            Console.WriteLine($"x / y = {x / (float)y}");
            Console.WriteLine($"y / x = {y / (float)x}");
        }

        /// <summary>
        /// Returns the division remainder
        /// </summary>
        static void DemoModulus()
        {
            int x = 2;
            int y = 3;
            int z = x % y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = x % y = {z}");
            Console.WriteLine($"x % y = {x % y}");
            Console.WriteLine($"y % x = {y % x}");
        }

        /// <summary>
        /// Increases the value of a variable by 1
        /// </summary>
        static void DemoIncrement()
        {
            int x = 1;
            x++;
            Console.WriteLine($"x = {x}");
        }

        /// <summary>
        /// Decreases the value of a variable by 1
        /// </summary>
        static void DemoDecrement()
        {
            int x = 1;
            x--;
            Console.WriteLine($"x = {x}");
        }
    }
}
