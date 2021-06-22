using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator3
{
    public class Calculator
    {
        public int LeftNumber { get; private set; }
        public string Operator { get; private set; }
        public int RightNumber { get; private set; }

        public Calculator(string expression)
        {
            var parsedValues = Regex.Match(expression, @"(\d+)([/+-/*/])(\d+)");
            LeftNumber = int.Parse(parsedValues.Groups[1].Value);
            Operator = parsedValues.Groups[2].Value;
            RightNumber = int.Parse(parsedValues.Groups[3].Value);
        }

        public void Reverse()
        {
            var temp = RightNumber;
            RightNumber = LeftNumber;
            LeftNumber = temp;
        }

        public void Calculate()
        {
            if (Operator == "+")
            {
                Console.WriteLine($"{LeftNumber}{Operator}{RightNumber} = {LeftNumber + RightNumber}");
            }
            else if (Operator == "-")
            {
                Console.WriteLine($"{LeftNumber}{Operator}{RightNumber} = {LeftNumber - RightNumber}");
            }
            else if (Operator == "*")
            {
                Console.WriteLine($"{LeftNumber}{Operator}{RightNumber} = {LeftNumber * RightNumber}");
            }
            else if (Operator == "/")
            {
                if (RightNumber == 0)
                {
                    Console.WriteLine("Cannot divide by 0.");
                    return;
                }
                Console.WriteLine($"{LeftNumber}{Operator}{RightNumber} = {LeftNumber / (decimal)RightNumber}");
            }
        }
    }
}
