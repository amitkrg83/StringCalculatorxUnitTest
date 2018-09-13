using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbr)
        {

            //default delimiter
            string delimeter = ",";

            //custom delimiter
            if (numbr.StartsWith("//"))
            {
                numbr = numbr.Substring(2);
                delimeter = GetDelimiterFromStringInput(numbr);
            }


            //replace new lines with delimeter
            numbr = numbr.Replace("\n", delimeter);

            //construct array of numbers
            var numbers = numbr.Split(delimeter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            List<int> negativeNumber = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;

                if (Int32.TryParse(numbers[i], out number))
                {
                    if (number < 0)
                    {
                        negativeNumber.Add(number);
                    }

                    if (number < 1000) sum += number;
                }
            }

            if (negativeNumber.Count > 0) throw new NegativeNumberException(negativeNumber);

            return sum;

        }

        private string GetDelimiterFromStringInput(string numbr)
        {
            var delimiter = numbr.Split('\n')[0];

            if (delimiter.StartsWith("["))
            {
                delimiter = delimiter.Substring(1, delimiter.Length - 2);
            }

            return delimiter;
        }
    }
}
