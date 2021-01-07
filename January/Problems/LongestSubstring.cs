using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace January.Problems
{
    public class LongestSubstring : IProblem
    {
        public string Title => "Longest Substring Without Repeating Characters";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3595/";

        public int LengthOfLongestSubstring(string input)
        {
            var result = 0;
            var mp = new Dictionary<char, int>();
            var startIndex = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (mp.ContainsKey(input[i]))
                {
                    startIndex = Math.Max(mp[input[i]], startIndex);
                }

                result = Math.Max(result, i - startIndex + 1);
                mp[input[i]] = i + 1;
            }
            return result;
        }
    }
}
