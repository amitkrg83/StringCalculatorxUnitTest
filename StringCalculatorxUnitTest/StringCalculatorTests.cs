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

            Assert.Equal( expectedVal, val.Add(String.Empty));
        }

        [Fact]
        public void ReturnNumberOnSingleNumber()
        {
            var val = new Calculator();

            var expectedVal = 100;

            Assert.Equal(expectedVal, val.Add("100"));
        }
    }
}
