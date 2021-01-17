using Shared.Interfaces;
using Shared.Models;
using System;
using Shared.Helpers;

namespace January.Problems
{
    public class KthLargestElementInAnArray : IProblem
    {
        public string Title => "Kth Largest Element in an Array";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3606/";

        public string FindKthLargestByUsingHeap(string input, string k)
        {
            try
            {
                var nums = DataConverter.ConvertStringToIntArray(input);
                var target = Convert.ToInt32(k);
                var result = FindKthLargestByUsingHeap(nums, target);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int FindKthLargestByUsingHeap(int[] nums, int k)
        {
            var heap = new MinHeap();
            for (int i = 0; i < nums.Length; i++)
            {
                heap.Add(nums[i]);
                if (heap.Size == k + 1)
                    heap.Poll();
            }
            return heap.Peek();
        }

        public int FindKthLargestByUsingArray(int[] nums, int k)
        {
           Array.Sort(nums);
           return nums[^k];
        }
    }
}
