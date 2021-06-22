using System;

namespace Returning
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array2 = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int found = 0;

            Console.WriteLine("Searching array1:");
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0)
                {
                    continue;
                }

                found++;
                Console.WriteLine(array1[i]);

                if (found == 2)
                {
                    break;
                    //return;
                }
            }

            if (found == 2)
            {
                return;
            }

            Console.WriteLine("Searching array2:");
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    continue;
                }

                found++;
                Console.WriteLine(array2[i]);

                if (found == 2)
                {
                    break;
                }
            }
        }
    }
}
