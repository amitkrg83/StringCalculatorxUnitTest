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
            String.Empty.StringAddTpNumbers(0);
        }

        [Fact]
        public void ReturnNumberOnSingleNumber()
        {
            "1".StringAddTpNumbers(1);
        }

        [Fact]
        public void ReturnSumOfTwoNumbersOnSupplyingTwoNumbers()
        {
            "7,5".StringAddTpNumbers(12);
        }

        [Fact]
        public void ReturnSumOfMultipleNumbersOnSupplyingMultipleNumbers()
        {
            "40,30,50".StringAddTpNumbers(120);
        }

        [Fact]
        public void AddMethodToReturnSumNewLinesBetweenNumbers()
        {
            "1\n2,3".StringAddTpNumbers(6);
        }

        [Fact]
        public void ToReturnExceptionIfTwoConsectiveDelimiters()
        {
            Assert.Throws<ArgumentException>(() => new Calculator().Add(",\n"));
        }

        [Fact]
        public void ToReturnSumOfStringsWhenCustomDelimiters()
        {
            "//;\n1;2".StringAddTpNumbers(3);
        }
    }

    internal static class AddTestHelper
    {
        public static void StringAddTpNumbers( this string strInput, int valueExpected)
        {
            var val = new Calculator();

            Assert.Equal(valueExpected, val.Add(strInput));
        }
    } 
}
