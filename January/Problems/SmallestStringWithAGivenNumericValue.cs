using System;
using Shared.Interfaces;

namespace January.Problems
{
    public class SmallestStringWithAGivenNumericValue : IProblem
    {
        public string Title => "Smallest String With A Given Numeric Value";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3619/";

        public string GetSmallestString(string input1, string input2)
        {
            try
            {
                var n = Convert.ToInt32(input1);
                var k = Convert.ToInt32(input2);
                return GetSmallestString(n, k);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetSmallestString(int n, int k)
        {
            var output = new char[n];
            for (var i = n - 1; i >= 0; i--)
            {
                var charValue = Math.Min(k - i, 26);
                output[i] = (char)(charValue + 96);
                k -= charValue;
            }
            return new string(output);
        }
    }
}
