using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbr)
        {


            var delimeters = ",\n";

            if (string.IsNullOrEmpty(numbr))
                return 0;

            if (numbr.Contains("//"))
            {
                delimeters += numbr[2];
                numbr = numbr.Substring(4, numbr.Length -4 );
            }
            var delimetersArr = numbr.Split(delimeters.ToCharArray());

            if (delimetersArr.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();
            return delimetersArr.Select(x => int.Parse(x)).Sum();

        }
    }
}
