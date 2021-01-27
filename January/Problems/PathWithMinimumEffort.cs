using Shared.Interfaces;
using System;
using Shared.Helpers;

namespace January.Problems
{
    public class PathWithMinimumEffort : IProblem
    {
        private readonly int[][] _directions = { new[] { 0, 1 }, new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, -1 } };
        public string Title => "Path With Minimum Effort";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3617/";

        public string MinimumEffortPath(string input)
        {
            try
            {
                var heights = DataConverter.ConvertStringToNestedArray(input);
                var result = MinimumEffortPath(heights);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int MinimumEffortPath(int[][] heights)
        {
            var start = 0;
            var end = 1000000;
            var m = heights.Length;
            var n = heights[0].Length;
            while (start < end)
            {
                var mid = start + (end - start) / 2;
                var visited = new bool[m, n];
                if (DoesPathExist(0, 0, mid, visited, heights[0][0], heights))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }

        private bool DoesPathExist(int x, int y, int k, bool[,] visited, int value, int[][] heights)
        {
            if (x < 0 || y < 0 || x >= heights.Length || y >= heights[0].Length || visited[x, y] || Math.Abs(value - heights[x][y]) > k)
            {
                return false;
            }

            if (x == heights.Length - 1 && y == heights[0].Length - 1)
            {
                return true;
            }

            visited[x, y] = true;

            foreach (var direction in _directions)
            {
                if (DoesPathExist(x + direction[0], y + direction[1], k, visited, heights[x][y], heights))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
