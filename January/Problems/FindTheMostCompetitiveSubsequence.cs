using System;
using Shared.Interfaces;
using System.Collections.Generic;
using Shared.Helpers;

namespace January.Problems
{
    public class FindTheMostCompetitiveSubsequence : IProblem
    {
        public string Title => "Find the Most Competitive Subsequence";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3611/";

        public string MostCompetitive(string input, string target)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var k = Convert.ToInt32(target);
                var result = MostCompetitive(nums, k);
                return $"[{string.Join(',', result)}]";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int[] MostCompetitive(int[] nums, int k)
        {
            if (nums.Length <= 1) return nums;

            var stack = new Stack<int>();
            stack.Push(nums[0]);
            for (var i = 1; i < nums.Length; i++)
            {
                while (stack.Count > 0 && k - stack.Count < (nums.Length - i) && stack.Peek() > nums[i])
                {
                    stack.Pop();
                }
                if(stack.Count < k) stack.Push(nums[i]);
            }

            var output = new int[k];
            for (int i = k-1; i >= 0; i--)
            {
                output[i] = stack.Pop();
            }

            return output;
        }

        //Time Limit Exceeds - Brute Force O(k * nums.Length) 
        public int[] MostCompetitive1(int[] nums, int k)
        {
            var output = new int[k];
            var startIndex = 0;
            for (var i = 0; i < k; i++)
            {
                var min = nums[startIndex];
                for (var j = startIndex + 1; j <= nums.Length - (k - i) ; j++)
                {
                    if (min > nums[j])
                    {
                        min = nums[j];
                        startIndex = j;
                    }
                }
                startIndex++;
                output[i] = min;
            }
            return output;
        }
    }
}
