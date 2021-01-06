using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class KthMissingPositiveNumber : IProblem
    {
        public string Title => "Kth Missing Positive Number";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3594/";

        public string FindKthPositive(string inputArray, string k)
        {
            try
            {
                if (!int.TryParse(k, out var targetNumber)) return Messages.InvalidInput;
                var input = DataConverter.ConvertStringToIntArray(inputArray);
                var result = FindKthPositive(input, targetNumber);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int FindKthPositive(int[] arr, int k)
        {
            var result = 0;
            for (int i = 0, j = 1; i < arr.Length && k >= 1; j++)
            {
                if (arr[i] != j)
                {
                    result = j;
                    k--;
                }
                else
                {
                    result = arr[i];
                    i++;
                }
            }
            return (result + k);
        }
    }
}
