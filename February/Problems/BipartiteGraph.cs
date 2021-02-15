using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class BipartiteGraph : IProblem
    {
        private int[] _parent;
        public string Title => "Is Graph Bipartite?";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3639/";

        public string IsBipartite(string input)
        {
            try
            {
                var graph = DataConverter.ConvertStringToNestedArray(input);
                return IsBipartite(graph).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool IsBipartite(int[][] graph)
        {
            _parent = new int[graph.Length];
            for (var i = 0; i < _parent.Length; i++)
            {
                _parent[i] = i;
            }

            for (var i = 0; i < graph.Length; i++)
            {
                for (var j = 0; j < graph[i].Length; j++)
                {
                    if (Find(i) == Find(graph[i][j])) return false;
                    Union(graph[i][j], graph[i][0]);
                }
            }
            return true;
        }

        private int Find(int point)
        {
            if (_parent[point] == point) return point;
            _parent[point] = Find(_parent[point]);
            return _parent[point];
        }

        private void Union(int a, int b)
        {
            var parent1 = Find(a);
            var parent2 = Find(b);

            if (parent1 != parent2)
                _parent[parent1] = parent2;
        }
    }
}
