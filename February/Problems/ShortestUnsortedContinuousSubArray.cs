using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class ShortestUnsortedContinuousSubArray : IProblem
    {
        public string Title => "Shortest Unsorted Continuous Subarray";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3652/";

        public string FindUnsortedSubArray(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var result = FindUnsortedSubArray(nums);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int FindUnsortedSubArray(int[] nums)
        {
            var map = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                map[i] = nums[i];
            }

            for (var i = 1; i < nums.Length; i++)
            {
                var index = i;
                while (i > 0 && map[i - 1] > map[i])
                {
                    var temp = map[i];
                    map[i] = map[i - 1];
                    map[i - 1] = temp;
                    i--;
                }
                i = index;
            }

            var startIndex = -1;
            var endIndex = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != map[i])
                {
                    if (startIndex == -1)
                    {
                        startIndex = i;
                    }
                    endIndex = i;
                }
            }

            return startIndex == -1 ? 0 : (endIndex - startIndex) + 1;
        }
    }
}
