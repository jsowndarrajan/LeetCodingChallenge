using Shared.Helpers;
using Shared.Interfaces;
using System;

namespace January.Problems
{
    public class MergeSortedArray : IProblem
    {
        public string Title => "Merge Sorted Array";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3600/";


        public string Merge(string nums1, string m, string nums2, string n)
        {
            try
            {
                var arr1 = DataConverter.ConvertStringToIntArray(nums1);
                var arr2 = DataConverter.ConvertStringToIntArray(nums2);
                var p = Convert.ToInt32(m);
                var q = Convert.ToInt32(n);
                Merge(arr1, p, arr2, q);

                return $"[{string.Join(',', arr1)}]";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var length = m + n;
            for (var i = n-1; i >= 0 && length > 0;)
            {
                if (m == 0)
                {
                    nums1[--length] = nums2[i];
                    i--;
                    continue;
                }

                if (nums2[i] > nums1[m - 1])
                {
                    nums1[--length] = nums2[i];
                    i--;
                }
                else
                {
                    nums1[--length] = nums1[--m];
                }
            }
        }
    }
}
