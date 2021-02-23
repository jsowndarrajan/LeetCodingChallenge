using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class SearchA2DMatrix2 : IProblem
    {
        public string Title => "Search a 2D Matrix II";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3650/";

        public string SearchMatrix(string input, string target)
        {
            try
            {
                if (int.TryParse(target, out var t))
                {
                    var m = DataConverter.ConvertStringToNestedArray(input);
                    var result = SearchMatrix(m, t);
                    return result.ToString();
                }
                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = 0;
            var column = matrix[0].Length - 1;

            while (row < matrix.Length && column >= 0)
            {
                if (matrix[row][column] == target) return true;
                else if (matrix[row][column] < target) row++;
                else column--;
            }

            return false;
        }
    }
}
