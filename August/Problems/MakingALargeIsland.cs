using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace August.Problems
{
    public class MakingALargeIsland : IProblem
    {
        public string Title => "Making A Large Island";
        public string Url => "https://leetcode.com/explore/featured/card/august-leetcoding-challenge-2021/613/week-1-august-1st-august-7th/3835/";

        private readonly int[,] _directions = { { 0, 1 }, { 1, 0 }, { -1, 0 }, { 0, -1 } };

        public int LargestIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            var max = 0;
            var islandId = 2;
            var map = new Dictionary<int, int>();
            map.Add(0, 0);

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var size = FindIslandSize(grid, i, j, islandId);
                        max = Math.Max(max, size);
                        map.Add(islandId++, size);
                    }
                }
            }

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        var set = new SortedSet<int>();
                        for (var k = 0; k < 4; k++)
                        {
                            var m = i + _directions[k, 0];
                            var n = j + _directions[k, 1];

                            if (m < 0 || n < 0 || m >= grid.Length || n >= grid[0].Length)
                            {
                                set.Add(0);
                            }
                            else
                            {
                                set.Add(grid[m][n]);
                            }
                        }

                        var sum = 1;
                        foreach (var iId in set)
                        {
                            sum += map[iId];
                        }

                        max = Math.Max(max, sum);
                    }
                }
            }

            return max;
        }

        private int FindIslandSize(int[][] grid, int i, int j, int islandId)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != 1) return 0;

            grid[i][j] = islandId;

            var sum = 1;
            for (var k = 0; k < 4; k++)
            {
                sum += FindIslandSize(grid, i + _directions[k, 0], j + _directions[k, 1], islandId);
            }
            return sum;
        }
    }
}