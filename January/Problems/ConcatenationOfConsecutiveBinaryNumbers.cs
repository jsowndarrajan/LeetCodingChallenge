using Shared.Interfaces;
using System;
using Shared.Helpers;

namespace January.Problems
{
    public class ConcatenationOfConsecutiveBinaryNumbers : IProblem
    {
        public string Title => "Concatenation of Consecutive Binary Numbers";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3618/";

        public string ConcatenatedBinary(string input)
        {
            if (!int.TryParse(input, out var n)) return Messages.InvalidInput;

            var result = ConcatenatedBinary(n);
            return result.ToString();
        }

        public int ConcatenatedBinary(int n)
        {
            long result = 0;
            for (var i = 1; i <= n; i++)
            {
                var numberOfDigits = (int)Math.Log(i, 2) + 1;
                result = ((result << numberOfDigits)% 1000000007 + i) % 1000000007;
            }
            return (int)result;
        }
    }
}
