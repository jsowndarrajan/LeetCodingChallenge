using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class DivideTwoIntegers : IProblem
    {
        public string Title => "Divide Two Integers";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3654/";

        public string Divide(string dividend, string divisor)
        {
            try
            {
                if (int.TryParse(dividend, out var input1) && int.TryParse(divisor, out var input2))
                {
                    var result = Divide(input1, input2);
                    return result.ToString();
                }
                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int Divide(int dividend, int divisor)
        {
            var isNegative = (dividend < 0 && divisor > 0)
                             ||
                             (dividend > 0 && divisor < 0);

            var absDividend = Math.Abs((long) dividend);
            var absDivisor = Math.Abs((long) divisor);

            long output = 0;
            while (absDividend >= absDivisor)
            {
                var temp = absDivisor;
                long quotient = 1;

                while (temp <= absDividend)
                {
                    temp <<= 1;
                    quotient <<= 1;
                }

                output += quotient >> 1;
                absDividend -= temp >> 1;
            }

            if (isNegative)
            {
                return ~(int)output + 1;
            }

            if (output > int.MaxValue)
                return int.MaxValue;

            return (int)output;
        }
    }
}
