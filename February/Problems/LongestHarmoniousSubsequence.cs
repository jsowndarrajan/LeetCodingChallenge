using Shared.Interfaces;
using System;
using System.Collections.Generic;
using Shared.Helpers;

namespace February.Problems
{
    public class LongestHarmoniousSubsequence : IProblem
    {
        public string Title => "Longest Harmonious Subsequence";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3628/";

        public string FindLHS(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var result = FindLHS(nums);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int FindLHS(int[] nums)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = map[nums[i]] + 1;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }

            var output = 0;
            foreach (var kp in map)
            {
                if (map.ContainsKey(kp.Key + 1))
                {
                    output = Math.Max(output, kp.Value + map[kp.Key + 1]);
                }
            }
            return output;
        }
    }
}
