using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbr)
        {
            if( string.IsNullOrEmpty(numbr))
                return 0;
            return int.Parse(numbr);
        }
    }
}
