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

            return numbr.Split(',', '\n').Select(x => int.Parse(x)).Sum();

        }
    }
}
