using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;

            //x y z
            //x z y
            //y x z
            //y z x
            //z x y
            //z y x

            if (x > y && x > z)
            {
                Console.WriteLine(x);
                if (y > z)
                {
                    Console.WriteLine(y);
                    Console.WriteLine(z);
                }
                else
                {
                    Console.WriteLine(z);
                    Console.WriteLine(y);
                }
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y);
                if (x > z)
                {
                    Console.WriteLine(x);
                    Console.WriteLine(z);
                }
                else
                {
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine(z);
                if (x > y)
                {
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
                else
                {
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
            }
        }
    }
}
