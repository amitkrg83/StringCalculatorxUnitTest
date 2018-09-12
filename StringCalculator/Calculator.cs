using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbr)
        {
            if (string.IsNullOrEmpty(numbr))
                return 0;

            var delimeters = numbr.Split(',', '\n');

            if (delimeters.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();
            return numbr.Split(',', '\n').Select(x => int.Parse(x)).Sum();

        }
    }
}
