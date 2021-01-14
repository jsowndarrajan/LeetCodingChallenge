using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class MinimumOperationsToReduceXToZero: IProblem
    {
        public string Title => "Minimum Operations to Reduce X to Zero";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3603/";

        public string MinOperations(string numbers, string target)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(numbers);
                var x = Convert.ToInt32(target);
                var result = MinOperations(nums, x);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Maximum length of subarray with sum = (Total - K)
        public int MinOperations(int[] nums, int x)
        {
            var subArraySum = -x;
            for (var i = 0; i < nums.Length; i++)
            {
                subArraySum += nums[i];
            }
            if (subArraySum < 0) return -1;
            if (subArraySum == 0) return nums.Length;

            var maxWindowSize = -1;
            var currentSum = 0;
            for (int i = 0, j = 0; i < nums.Length && j < nums.Length; j++)
            {
                currentSum += nums[j];

                while (currentSum > subArraySum)
                {
                    currentSum -= nums[i++];
                }

                if (currentSum == subArraySum)
                {
                    maxWindowSize = Math.Max(maxWindowSize, (j - i) + 1);
                }
            }
            return maxWindowSize == -1 ? -1: nums.Length - maxWindowSize;
        }
    }
}
