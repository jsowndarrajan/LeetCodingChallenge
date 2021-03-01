using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace March.Problems
{
    public class DistributeCandies : IProblem
    {
        public string Title => "Distribute Candies";
        public string Url => "https://leetcode.com/explore/featured/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3657/";

        public string Calculate(string candyType)
        {
            try
            {
                var input = DataConverter.ConvertStringToIntArray(candyType);
                var result = Calculate(input);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int Calculate(int[] input)
        {
            var max = input.Length / 2;
            var hashset = new HashSet<int>(input);
            return Math.Min(hashset.Count, max);
        }
    }
}
