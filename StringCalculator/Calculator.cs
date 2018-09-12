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
            if (numbr.Contains(","))
                return int.Parse(numbr[0].ToString())+ int.Parse(numbr[2].ToString());
            return int.Parse(numbr);
        }
    }
}
