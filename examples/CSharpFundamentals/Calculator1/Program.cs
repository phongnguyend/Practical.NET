using System;
using System.Text.RegularExpressions;

namespace Calculator1
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

                var parsedValues = Regex.Match(expression, @"(\d+)([/+-/*/])(\d+)");
                var leftNumber = int.Parse(parsedValues.Groups[1].Value);
                var @operator = parsedValues.Groups[2].Value;
                var rightNumber = int.Parse(parsedValues.Groups[3].Value);

                if (@operator == "+")
                {
                    Console.WriteLine($"{expression} = {leftNumber + rightNumber}");
                }
                else if (@operator == "-")
                {
                    Console.WriteLine($"{expression} = {leftNumber - rightNumber}");
                }
                else if (@operator == "*")
                {
                    Console.WriteLine($"{expression} = {leftNumber * rightNumber}");
                }
                else if (@operator == "/")
                {
                    if (rightNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by 0.");
                        continue;
                    }
                    Console.WriteLine($"{expression} = {leftNumber / (decimal)rightNumber}");
                }
            }
        }
    }
}
