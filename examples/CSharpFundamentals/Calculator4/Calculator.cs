using System.Text.RegularExpressions;

namespace Calculator4
{
    public abstract class Calculator
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

        public virtual void Reverse()
        {
            var temp = RightNumber;
            RightNumber = LeftNumber;
            LeftNumber = temp;
        }

        public abstract void Calculate();

        public void Dowork()
        {
            Calculate();
            Reverse();
            Calculate();
        }
    }
}
