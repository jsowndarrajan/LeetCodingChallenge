using Shared.Interfaces;

namespace January.Tests.Problems
{
    public class MergeSortedArray : IProblem
    {
        public string Title => "Merge Sorted Array";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3600/";

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
