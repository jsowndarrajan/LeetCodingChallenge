using Shared.Interfaces;
using System;
using System.Diagnostics;

namespace March.Problems
{
    public class WiggleSubsequence : IProblem
    {
        public string Title => "Wiggle Subsequence";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3676/";
        
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            var output = 1;
            var startIndex = 1;
            while (nums[startIndex - 1] == nums[startIndex])
            {
                startIndex++;
                if (startIndex == nums.Length)
                {
                    return output;
                }
            }

            output = 2;
            var previousNumber = nums[startIndex];
            var previousDiffNegative = nums[startIndex - 1] > nums[startIndex];
            for (var i = startIndex + 1; i < nums.Length; i++)
            {
                if(previousNumber == nums[i]) continue;

                var currentDiffNegative = previousNumber > nums[i];

                if (previousDiffNegative != currentDiffNegative)
                {
                    previousDiffNegative = currentDiffNegative;
                    previousNumber = nums[i];
                    output++;
                }
                else
                {
                    previousNumber = previousDiffNegative
                        ? Math.Min(previousNumber, nums[i])
                        : Math.Max(previousNumber, nums[i]);
                }
            }
            return output;
        }
    }
}
