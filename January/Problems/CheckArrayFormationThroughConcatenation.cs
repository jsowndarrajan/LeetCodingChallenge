using System;
using System.Collections.Generic;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class CheckArrayFormationThroughConcatenation: IProblem
    {
        public string Title => "Check Array Formation Through Concatenation";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3589/";

        public string CanFormArray(string targetArray, string pieces)
        {
            if (string.IsNullOrWhiteSpace(targetArray) || string.IsNullOrWhiteSpace(pieces)) return Messages.InvalidInput;
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

        public bool CanFormArray(int[] targetArray, int[][] pieces)
        {
            var map = new Dictionary<int,int>();

            for (var i = 0; i < targetArray.Length; i++)
            {
                map.Add(targetArray[i], i);
            }

            var piecesLength = 0;
            foreach (var piece in pieces)
            {
                if (piece.Length < 1) continue;
                if (!map.ContainsKey(piece[0])) return false;

                piecesLength += piece.Length;
                var index = map[piece[0]] + 1;

                for (var i = 1; i < piece.Length; i++)
                {
                    if (index >= targetArray.Length || piece[i] != targetArray[index]) return false;
                    index++;
                }
            }

            return targetArray.Length == piecesLength;
        }
    }
}
