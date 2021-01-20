using System;
using Shared.Interfaces;

namespace January.Problems
{
    public class LongestPalindromicSubstring : IProblem
    {
        public string Title => "Longest Palindromic Substring";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3609/";

        public string LongestPalindrome(string input)
        {
            if (input.Length < 2) return input;

            var currentLongestLength = 0;
            var start = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var palindrome1 = CheckPalindromeLength(input, i, i);
                var palindrome2 = CheckPalindromeLength(input, i, i + 1);
                var longestLength = Math.Max(palindrome1, palindrome2);
                if (longestLength > currentLongestLength)
                {
                    currentLongestLength = longestLength;
                    start = i - (longestLength - 1) / 2;
                }
            }
            return input.Substring(start, currentLongestLength);
        }

        private int CheckPalindromeLength(string input, int begin, int end)
        {
            while (begin >= 0 && end < input.Length && input[begin] == input[end])
            {
                begin--;
                end++;
            }
            return end - begin - 1;
        }
    }
}
