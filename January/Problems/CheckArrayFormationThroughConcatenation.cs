using System;
using January.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class CheckArrayFormationThroughConcatenation: IProblem
    {
        public string Title => "Check Array Formation Through Concatenation";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3589/";

        public string CanFormArray(string targetArray, string pieces)
        {
            if (string.IsNullOrWhiteSpace(targetArray) || string.IsNullOrWhiteSpace(pieces)) return "Invalid Input";
            try
            {
                var array = DataConverter.ConvertStringToIntArray(targetArray);
                var piecesArray = DataConverter.ConvertStringToNestedArray(pieces);
                return CanFormArray(array, piecesArray).ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            return false;
        }
    }
}
