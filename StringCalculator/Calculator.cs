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
                numbr = numbr.Substring(4, numbr.Length - 4);
            }
            var delimetersArr = numbr.Split(delimeters.ToCharArray());

            if (delimetersArr.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();

            var intNumbers = delimetersArr.Select(x => int.Parse(x));

            var negativeIntNumbers = intNumbers.Where(x => x < 0);

            if (negativeIntNumbers.Count() > 0)
            {
                var msg = "Negative Not Allowed: {0}";

                throw new ArgumentOutOfRangeException(string.Format(msg, string.Join(",", negativeIntNumbers.Select(x => x.ToString()).ToArray())));
            }

            return delimetersArr.Select(x => int.Parse(x)).Sum();

            //return delimetersArr.Where(x => int.Parse(x) <= 1000).Sum(x => int.Parse(x));

        }
    }
}
