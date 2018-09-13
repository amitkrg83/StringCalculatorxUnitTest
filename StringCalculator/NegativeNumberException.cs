using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(List<int> numbers) : base(generateMessage(numbers))
        {
        }

        private static string generateMessage(List<int> numbers)
        {
            return "negatives not allowed: " + String.Join(" ", numbers.Select(x => x));
        }

        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}
