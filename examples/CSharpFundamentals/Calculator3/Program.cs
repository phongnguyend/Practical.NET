using System;

namespace Calculator3
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

                var calculator = new Calculator(expression);
                calculator.Calculate();
                calculator.Reverse();
                calculator.Calculate();
            }
        }
    }
}
