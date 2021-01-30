using System;
using Shared.Interfaces;
using System.Collections.Generic;
using Shared.Helpers;

namespace January.Problems
{
    public class MinimizeDeviationInArray : IProblem
    {
        public string Title => "Minimize Deviation in Array";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/583/week-5-january-29th-january-31st/3622/";

        public string MinimumDeviation(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var result = MinimumDeviation(nums);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int MinimumDeviation(int[] nums)
        {
            var set = new SortedSet<int>();
            foreach (var num in nums)
            {
                set.Add(num);
            }

            var md = ApplyOperations(set);
            return md;
        }

        private int ApplyOperations(SortedSet<int> set)
        {
            var md = set.Max - set.Min;

            while (set.Min % 2 > 0)
            {
                var temp = set.Min;
                set.Remove(temp);
                set.Add(temp * 2);
                md = Math.Min(md, set.Max - set.Min);
            }

            while (set.Max % 2 == 0)
            {
                var temp = set.Max;
                set.Remove(temp);
                set.Add(temp / 2);
                md = Math.Min(md, set.Max - set.Min);
            }
            return md;
        }
    }
}
