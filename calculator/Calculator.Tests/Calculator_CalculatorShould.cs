using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractTwoIntergers()
        {
            int difference = _calculator.Subtract(30, 20);

            Assert.Equal(difference, 10);
        }
    }
}
