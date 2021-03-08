using Shared.Interfaces;

namespace March.Problems
{
    public class RemovePalindromicSubsequence : IProblem
    {
        public string Title => "Remove Palindromic Subsequence";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3665/";

        public int RemovePalindromeSub(string input)
        {
            if (input.Length <= 1) return input.Length;
            return IsPalindrome(input) ? 1 : 2;
        }

        private bool IsPalindrome(string input)
        {
            var i = 0;
            var j = input.Length - 1;
            while (i < j)
            {
                if (input[i] != input[j]) return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
