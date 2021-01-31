using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using System;

namespace January.Problems
{
    public class NextPermutation : IProblem
    {
        public string Title => "Next Permutation";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/583/week-5-january-29th-january-31st/3623/";

        public string FindNextPermutation(string input)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                FindNextPermutation(nums);
                return JsonConvert.SerializeObject(nums);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void FindNextPermutation(int[] nums)
        {
            var index = -1;
            for (var j = nums.Length - 1; j > 0; j--)
            {
                if (nums[j] > nums[j - 1])
                {
                    index = j - 1;
                    break;
                }
            }

            if (index != -1)
            {
                var nextMax = nums[index];
                var currentMaxIndex = -1;
                for (int i = index + 1; i < nums.Length; i++)
                {
                    if (nums[i] > nextMax)
                    {
                        if (currentMaxIndex == -1)
                        {
                            currentMaxIndex = i;
                        }
                        else
                        {
                            if (nums[currentMaxIndex] > nums[i])
                            {
                                currentMaxIndex = i;
                            }
                        }
                    }
                }

                var temp = nums[currentMaxIndex];
                nums[currentMaxIndex] = nums[index];
                nums[index] = temp;

                Array.Sort(nums, index + 1, nums.Length - (index + 1));
            }
            else
            {
                Array.Sort(nums);
            }
        }
    }
}
