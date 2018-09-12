using StringCalculator;
using System;
using Xunit;

namespace StringCalculatorxUnitTest
{
    public class StringCalculatorTests
    {
        [Fact]
        public void ReturnZeroOnEmptyString()
        {
            var val = new Calculator();

            var expectedVal = 0;

            Assert.Equal( expectedVal, Calculator.Add(String.Empty));
        }
    }
}
