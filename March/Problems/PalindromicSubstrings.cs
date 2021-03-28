using Shared.Interfaces;

namespace March.Problems
{
    public class PalindromicSubstrings : IProblem
    {
        public string Title => "Palindromic Substrings";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/591/week-4-march-22nd-march-28th/3686/";
        
        public int CountSubstrings(string input)
        {
            var output = 0;
            var dp = new bool[input.Length, input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                var j = i;
                if (input[i] == input[j])
                {
                    output++;
                    dp[i, j] = true;
                }

                if (j + 1 < input.Length && input[i] == input[j + 1])
                {
                    output++;
                    dp[i, j+1] = true;
                }
            }

            for (var i = input.Length - 2; i >= 0; i--)
            {
                for (var j = i+2; j < input.Length; j++)
                {
                    if (input[i] == input[j] && dp[i+1, j-1])
                    {
                        output++;
                        dp[i, j] = true;
                    }
                }
            }
            return output;
        }
    }
}
