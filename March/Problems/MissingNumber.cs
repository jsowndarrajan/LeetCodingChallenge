using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace March.Problems
{
    public class MissingNumber : IProblem
    {
        public string Title => "Missing Number";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3659/";

        public string Compute(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var result = Compute(nums);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int Compute(int[] nums)
        {
            var actualSum = 0;
            foreach (var item in nums)
            {
                actualSum += item;
            }

            var expectedSum = (nums.Length * (nums.Length + 1)) / 2;

            return expectedSum - actualSum;
        }
    }
}
