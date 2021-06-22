using System;
using System.Text;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            Demo6();
        }

        private static void Demo1()
        {
            string message1 = "Hello ";
            string message2 = message1;
            Console.WriteLine("Initial:");
            Console.WriteLine($"message1 = {message1}");
            Console.WriteLine($"message2 = {message2}");

            message1 += 2021;
            message2 += 2022;
            Console.WriteLine("Updated:");
            Console.WriteLine($"message1 = {message1}");
            Console.WriteLine($"message2 = {message2}");
        }

        private static void Demo2()
        {
            string message = "Hello ";
            Console.WriteLine("Initial:");
            Console.WriteLine($"message = {message}");

            UpdateMessage(message);
            //UpdateMessage2(ref message);

            Console.WriteLine("Updated:");
            Console.WriteLine($"message = {message}");
        }

        static void UpdateMessage(string message)
        {
            Console.WriteLine($"message = {message}");
            message += "2021";
            Console.WriteLine($"message = {message}");
        }

        static void UpdateMessage2(ref string message)
        {
            Console.WriteLine($"message = {message}");
            message += "2021";
            Console.WriteLine($"message = {message}");
        }

        private static void Demo3()
        {
            string message = "Hello ";
            Console.WriteLine("Initial:");
            Console.WriteLine($"message = {message}");

            message += "2021";
            message.ToUpper();

            Console.WriteLine("Updated:");
            Console.WriteLine($"message = {message}");
        }

        private static void Demo4()
        {
            string message = "Hello ";
            Console.WriteLine("Initial:");
            Console.WriteLine($"message = {message}");

            message += "2021";
            message = message.ToUpper();

            Console.WriteLine("Updated:");
            Console.WriteLine($"message = {message}");
        }

        private static void Demo5()
        {
            string message = "Hello ";
            Console.WriteLine("Initial:");
            Console.WriteLine($"message = {message}");

            for (int i = 0; i < 1000; i++)
            {
                message += i;
                message += " ";
            }

            Console.WriteLine("Updated:");
            Console.WriteLine($"message = {message}");
        }

        private static void Demo6()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");

            string message = builder.ToString();

            Console.WriteLine("Initial:");
            Console.WriteLine($"message = {message}");

            for (int i = 0; i < 1000; i++)
            {
                builder.Append(i + " ");
            }

            message = builder.ToString();

            Console.WriteLine("Updated:");
            Console.WriteLine($"message = {message}");
        }
    }
}
