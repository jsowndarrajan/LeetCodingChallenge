using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace February.Problems
{
    public class ShortestPathInBinaryMatrix : IProblem
    {
        public string Title => "Shortest Path in Binary Matrix";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3638/";

        private readonly int[][] _nextPoints = {new[] {-1, 1}, new[] {1, 0}, new[] {1, 1}, new[] {-1, 0}, new[] {0, 1}, new[] {-1, -1}, new[] {-1, 0}, new[] { 1, -1}};

        public string ShortestPathBinaryMatrix(string input)
        {
            try
            {
                var grid = DataConverter.ConvertStringToNestedArray(input);
                var result = ShortestPathBinaryMatrix(grid);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            var queue = new Queue<Tuple<int, int>>();
            var row = grid.Length;
            var column = grid[0].Length;
            var visited = new bool[row, column];

            if (row == 0 || column == 0) return -1;
            if (grid[0][0] == 1) return -1;

            queue.Enqueue(new Tuple<int, int>(0, 0));
            visited[0, 0] = true;
            var level = 0;
            while (queue.Count > 0)
            {
                var nodesCount = queue.Count;
                level++;
                while (nodesCount > 0)
                {
                    var node = queue.Dequeue();

                    if (node.Item1 == row - 1 && node.Item2 == column - 1)
                    {
                        return (grid[node.Item1][node.Item2] == 0) ? level : -1;
                    }

                    foreach (var nextPoint in _nextPoints)
                    {
                        var newRowIndex = node.Item1 + nextPoint[0];
                        var newColumnIndex = node.Item2 + nextPoint[1];

                        if (newRowIndex >= 0 && newRowIndex < row
                                            && newColumnIndex >= 0 && newColumnIndex < column
                                            && grid[newRowIndex][newColumnIndex] == 0
                                            && !visited[newRowIndex, newColumnIndex])
                        {
                            queue.Enqueue(new Tuple<int, int>(newRowIndex, newColumnIndex));
                            visited[newRowIndex, newColumnIndex] = true;
                        }
                    }
                    nodesCount--;
                }
            }
            return -1;
        }
    }
}
