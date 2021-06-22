using System;

namespace Jumping
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int found = 0;

            Console.WriteLine("Using for:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    continue;
                }

                found++;
                Console.WriteLine(array[i]);

                if (found == 2)
                {
                    break;
                }
            }

            Console.WriteLine("Using foreach:");
            found = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    continue;
                }

                found++;
                Console.WriteLine(number);

                if (found == 2)
                {
                    break;
                }
            }

            Console.WriteLine("Using while:");
            found = 0;
            int i2 = 0;
            while (i2 < array.Length)
            {
                if (array[i2] % 2 != 0)
                {
                    i2++;
                    continue;
                }

                found++;
                Console.WriteLine(array[i2]);
                i2++;

                if (found == 2)
                {
                    break;
                }
            }

            Console.WriteLine("Using do while:");
            found = 0;
            int i3 = 0;
            do
            {
                if (array[i3] % 2 != 0)
                {
                    i3++;
                    continue;
                }

                found++;
                Console.WriteLine(array[i3]);
                i3++;

                if (found == 2)
                {
                    break;
                }
            }
            while (i3 < array.Length);
        }
    }
}
