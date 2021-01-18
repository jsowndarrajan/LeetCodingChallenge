using System;
using System.Collections.Generic;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class MaxNumberOfKSumPairs : IProblem
    {
        public string Title => "Max Number of K-Sum Pairs";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3608/";

        public string MaxOperationsByUsingArraySort(string input, string target)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var k = Convert.ToInt32(target);
                var result = MaxOperationsByUsingArraySort(nums, k);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int MaxOperationsByUsingArraySort(int[] nums, int k)
        {
            Array.Sort(nums);

            var start = 0;
            var end = nums.Length - 1;
            var count = 0;

            while (start < end)
            {
                if (nums[start] + nums[end] > k)
                {
                    end--;
                }
                else if (nums[start] + nums[end] < k)
                {
                    start++;
                }
                else
                {
                    start++;
                    end--;
                    count++;
                }
            }

            return count;
        }

        public int MaxOperationsByUsingDictionary1(int[] nums, int k)
        {
            var result = 0;
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] += 1;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }

            foreach (var kp in map)
            {
                var remainingPair = k - kp.Key;
                if (map.ContainsKey(remainingPair))
                {
                    result += Math.Min(map[remainingPair], kp.Value);
                }
            }

            return result / 2;
        }

        public int MaxOperationsByUsingDictionary2(int[] nums, int k)
        {
            var result = 0;
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var remainingNumber = k - nums[i];

                if (map.ContainsKey(remainingNumber))
                {
                    if (map[remainingNumber] > 1)
                    {
                        map[remainingNumber] = map[remainingNumber] - 1;
                    }
                    else
                    {
                        map.Remove(remainingNumber);
                    }
                    result++;
                }
                else
                {
                    if (map.ContainsKey(remainingNumber))
                    {
                        map[nums[i]] = map[nums[i]] + 1;
                    }
                    else
                    {
                        map.Add(nums[i], 1);
                    }
                }
            }

            return result;
        }
    }
}
