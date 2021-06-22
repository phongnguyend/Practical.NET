using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator4
{
    public class DivisionCalculator : Calculator
    {
        public DivisionCalculator(string expression) : base(expression)
        {

        }

        public override void Calculate()
        {
            if (Operator == "/")
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
