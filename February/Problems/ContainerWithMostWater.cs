using Shared.Helpers;
using System;
using Shared.Interfaces;

namespace February.Problems
{
    public class ContainerWithMostWater : IProblem
    {
        public string Title => "Container With Most Water";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3643/";

        public string MaxArea(string input)
        {
            try
            {
                var height = DataConverter.ConvertStringToIntArray(input);
                var result = MaxArea(height);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int MaxArea(int[] height)
        {
            var i = 0;
            var j = height.Length - 1;
            var water = 0;

            while (i != j)
            {
                var xAxisLength = j - i;

                if (height[j] < height[i])
                {
                    water = Math.Max(water, xAxisLength * height[j]);
                    j--;
                }
                else
                {
                    water = Math.Max(water, xAxisLength * height[i]);
                    i++;
                }
            }

            return water;
        }
    }
}
