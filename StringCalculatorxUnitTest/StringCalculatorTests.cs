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

            var expectedVal = 1;

            Assert.Equal(expectedVal, val.Add("1"));
        }

        [Fact]
        public void ReturnSumOfTwoNumbersOnSupplyingTwoNumbers()
        {
            var val = new Calculator();

            var expectedVal = 12;

            Assert.Equal(expectedVal, val.Add("7,5"));
        }

        [Fact]
        public void ReturnSumOfMultipleNumbersOnSupplyingMultipleNumbers()
        {
            var val = new Calculator();

            var expectedVal = 120;

            Assert.Equal(expectedVal, val.Add("40,30,50"));
        }
    }
}
