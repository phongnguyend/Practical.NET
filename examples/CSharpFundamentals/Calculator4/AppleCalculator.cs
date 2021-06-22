using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator4
{
    public class AppleCalculator : Calculator
    {
        private List<Calculator> _calculators;

        public AppleCalculator(string expression) : base(expression)
        {
            _calculators = new List<Calculator> {
            new MultiplicationCalculator(expression),
            new DivisionCalculator(expression)
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
