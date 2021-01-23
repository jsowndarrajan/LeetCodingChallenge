using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace January.Problems
{
    public class SortTheMatrixDiagonally: IProblem
    {
        public string Title => "Sort the Matrix Diagonally";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3614/";

        public string DiagonalSort(string input)
        {
            try
            {
                var matrix = DataConverter.ConvertStringToNestedArray(input);
                var result = DiagonalSort(matrix);
                return JsonConvert.SerializeObject(result);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int[][] DiagonalSort(int[][] mat)
        {
            var map = new Dictionary<int, List<int>>();

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    var index = i - j;

                    if (map.ContainsKey(index))
                    {
                        Add(map[index], mat[i][j]);
                    }
                    else
                    {
                        map[index] = new List<int> {mat[i][j]};
                    }
                }
            }

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    var index = i - j;
                    mat[i][j] = map[index][0];
                    map[index].Remove(map[index][0]);
                }
            }

            return mat;
        }

        private void Add(List<int> input, int value)
        {
            input.Add(value);
            input.Sort();
        }
    }
}
