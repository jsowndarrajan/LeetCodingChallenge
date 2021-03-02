using System;
using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;

namespace March.Problems
{
    public class SetMismatch : IProblem
    {
        public string Title => "Set Mismatch";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3658/";

        public string FindErrorNums(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var result = FindErrorNums(nums);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int[] FindErrorNums(int[] nums)
        {
            var map = new int[nums.Length + 1];
            var output = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                map[nums[i]] += 1;
            }

            for (var i = 1; i < map.Length; i++)
            {
                if (map[i] == 0)
                {
                    output[1] = i;
                }

                if (map[i] == 2)
                {
                    output[0] = i;
                }
            }
            return output;
        }
    }
}
