using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutExceptionHandling();
            //WithExceptionHandling1();
            //WithExceptionHandling2();
            //WithExceptionHandling3();

            //try
            //{
            //    WithExceptionHandling4();
            //}
            //catch (MyCustomException ex)
            //{
            //    Console.WriteLine("Please retry again.");
            //    Main(args);
            //}
        }

        private static void WithoutExceptionHandling()
        {
            Console.WriteLine("Please enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"x/y = {x / (decimal)y}");
        }

        private static void WithExceptionHandling1()
        {
            try
            {
                Console.WriteLine("Please enter x:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter y:");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine($"x/y = {x / (decimal)y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WithExceptionHandling2()
        {
            try
            {
                Console.WriteLine("Please enter x:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter y:");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine($"x/y = {x / (decimal)y}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y cannot be 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WithExceptionHandling3()
        {
            int x = 0, y = 0;
            try
            {
                Console.WriteLine("Please enter x:");
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("X must be valid number.");
            }

            try
            {
                Console.WriteLine("Please enter y:");
                y = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Y must be valid number.");
            }

            try
            {
                Console.WriteLine($"x/y = {x / (decimal)y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y cannot be 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        private static void WithExceptionHandling4()
        {
            int x = 0, y = 0;
            try
            {
                Console.WriteLine("Please enter x:");
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("X must be valid number.");
                throw new MyCustomException("X must be valid number.");
            }

            try
            {
                Console.WriteLine("Please enter y:");
                y = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Y must be valid number.");
                throw new MyCustomException("Y must be valid number.");
            }

            try
            {
                Console.WriteLine($"x/y = {x / (decimal)y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y cannot be 0.");
                throw new MyCustomException("Y cannot be 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
