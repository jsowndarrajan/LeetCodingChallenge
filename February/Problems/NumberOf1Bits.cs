using System;
using Shared.Interfaces;

namespace February.Problems
{
    public class NumberOf1Bits : IProblem
    {
        public string Title => "Number of 1 Bits";
        public string Url => "https://leetcode.com/explore/featured/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3625/";
        
        public string HammingWeight(string input)
        {
            try
            {
                var n = Convert.ToUInt32(input, 2);
                var result = HammingWeight(n);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int HammingWeight(uint n)
        {
            var result = 0;
            while (n > 0)
            {
                if(n % 2 > 0) result++;
                n /= 2;
            }
            return result;
        }

        public int HammingWeight1(uint n)
        {
            var input = Convert.ToString(n, 2);
            var result = 0;
            foreach (var bit in input)
            {
                if (bit == '1') result++;
            }
            return result;
        }
    }
}
