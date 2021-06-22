using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator4
{
    public class SamsungCalculator : Calculator
    {
        private List<Calculator> _calculators;

        public SamsungCalculator(string expression) : base(expression)
        {
            _calculators = new List<Calculator> {
            new AdditionCalculator(expression),
            new SubtractionCalculator(expression)
            };
        }

        public override void Reverse()
        {
            foreach (var calculator in _calculators)
            {
                calculator.Reverse();
            }
        }

        public override void Calculate()
        {
            foreach (var calculator in _calculators)
            {
                calculator.Calculate();
            }
        }
    }
}
