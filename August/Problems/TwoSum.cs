using System.Collections.Generic;
using Shared.Interfaces;

namespace August.Problems
{
    public class TwoSum : IProblem
    {
        public string Title => "Two Sum";
        public string Url => "https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/613/week-1-august-1st-august-7th/3836/";

        public int[] Calculate(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var reminder = target - nums[i];
                if (map.ContainsKey(reminder))
                {
                    return new[] {map[reminder], i};
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}