using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;

            var array = new int[] { x, y, z };

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Using for:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Using foreach:");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Using while:");
            int i2 = 0;
            while (i2 < array.Length)
            {
                Console.WriteLine(array[i2]);
                i2++;
            }

            Console.WriteLine("Using do while:");
            int i3 = 0;
            do
            {
                Console.WriteLine(array[i3]);
                i3++;
            }
            while (i3 < array.Length);
        }
    }
}
