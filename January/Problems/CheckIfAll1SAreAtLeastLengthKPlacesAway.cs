using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class CheckIfAll1SAreAtLeastLengthKPlacesAway : IProblem
    {
        public string Title => "Check If All 1's Are at Least Length K Places Away";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3616/";

        public string KLengthApart(string input, string distance)
        {
            try
            {
                if (int.TryParse(distance, out var k))
                {
                    var nums = DataConverter.ConvertStringToIntArray(input);
                    var result = KLengthApart(nums, k);
                    return result.ToString();

                }
                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool KLengthApart(int[] nums, int k)
        {
            if (k == 0) return true;

            var previousIndex = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 1) continue;

                if (previousIndex != -1)
                {
                    var distance = i - previousIndex - 1;

                    if (distance < k) return false;
                }
                previousIndex = i;
            }
            return true;
        }
    }
}
