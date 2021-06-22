using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoArray1();
            //DemoArray2();
            //DemoArray3();
            //DemoArray4();
        }

        static void DemoArray1()
        {
            int[] array = new int[5];
            array[0] = 2;
            array[1] = 4;
            array[2] = 6;
            array[3] = 8;
            array[4] = 10;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoArray2()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoArray3()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10 };

            array[2] = 60;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoArray4()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10 };

            array[5] = 12;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
