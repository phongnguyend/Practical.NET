using System;

namespace Calculator4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter Expression:");
                var expression = Console.ReadLine();

                if (expression == "quit")
                {
                    return;
                }

                Calculator calculator = new AppleCalculator(expression);
                //calculator.Calculate();
                //calculator.Reverse();
                //calculator.Calculate();
                calculator.Dowork();
            }
        }
    }
}
