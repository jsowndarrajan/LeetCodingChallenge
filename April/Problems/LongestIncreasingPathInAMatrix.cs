using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace April.Problems
{
    public class LongestIncreasingPathInAMatrix : IProblem
    {
        public string Title => "Longest Increasing Path in a Matrix";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3703/";

        private readonly List<Point> _directions = new List<Point>
        {
            new Point(0, 1),
            new Point(0, -1),
            new Point(1, 0),
            new Point(-1, 0),
        };
        private int[,] _map;

        public int LongestIncreasingPath(int[][] matrix)
        {
            _map = new int[matrix.Length, matrix[0].Length];

            var output = 0;
            for (var x = 0; x < matrix.Length; x++)
            {
                for (var y = 0; y < matrix[x].Length; y++)
                {
                    output = Math.Max(output, FindLongestIncreasingOrderUsingDfs(matrix, x, y));
                }
            }
            return output;
        }

        private int FindLongestIncreasingOrderUsingDfs(int[][] matrix, int x, int y)
        {
            if (_map[x, y] != 0) return _map[x, y];

            var currentMax = 0;
            for (var i = 0; i < _directions.Count; i++)
            {
                var x1 = x + _directions[i].X;
                var y1 = y + _directions[i].Y;

                if (x1 < matrix.Length && y1 < matrix[0].Length && x1 >= 0 && y1 >= 0)
                {
                    if (matrix[x][y] < matrix[x1][y1])
                    {
                        currentMax = Math.Max(currentMax, FindLongestIncreasingOrderUsingDfs(matrix, x1, y1));
                    }
                }
            }

            _map[x, y] = currentMax + 1;
            return _map[x, y];
        }

        private class Point
        {
            public int X { get; }

            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
