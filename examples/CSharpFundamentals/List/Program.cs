using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoList1();
            //DemoList2();
            //DemoList3();
            //DemoList4();
            DemoList5();
        }

        static void DemoList1()
        {
            List<int> list = new List<int>();
            list[0] = 2;
            list[1] = 4;
            list[2] = 6;
            list[3] = 8;
            list[4] = 10;

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoList2()
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(8);
            list.Add(10);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoList3()
        {
            List<int> list = new List<int> { 2, 4, 6, 8, 10 };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoList4()
        {
            List<int> list = new List<int> { 2, 4, 6, 8, 10 };

            list[2] = 60;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void DemoList5()
        {
            List<int> list = new List<int> { 2, 4, 6, 8, 10 };
            list.Add(12);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list[5] = 120;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
