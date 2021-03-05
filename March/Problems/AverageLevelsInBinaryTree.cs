using System;
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Shared.Helpers;

namespace March.Problems
{
    public class AverageLevelsInBinaryTree : IProblem
    {
        public string Title => "Average of Levels in Binary Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3661/";

        public string AverageOfLevelsUsingStack(string input)
        {
            try
            {
                var root = DataConverter.ConvertStringArrayToTreeNode(input);
                var result = AverageOfLevelsUsingStack(root);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IList<double> AverageOfLevelsUsingStack(TreeNode root)
        {
            var output = new List<double>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var count = queue.Count;
                var levelCount = queue.Count;
                double sum = 0;

                while (levelCount > 0)
                {
                    var node = queue.Dequeue();
                    sum += node.Value;

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }

                    levelCount--;
                }
                output.Add(sum / count);
            }
            return output;
        }

        public IList<double> AverageOfLevelsByUsingDictionary(TreeNode root)
        {
            var map = new Dictionary<int, Result>();
            Traversal(root, map, 0);
            return map.Values.Select(x => x.Average).ToList();
        }

        private void Traversal(TreeNode root, Dictionary<int, Result> map, int level)
        {
            if(root == null) return;

            if (map.ContainsKey(level))
            {
                map[level].Sum += root.Value;
                map[level].Count += 1;
            }
            else
            {
                map.Add(level, new Result { Sum = root.Value, Count = 1 });
            }

            Traversal(root.Left, map, level + 1);
            Traversal(root.Right, map, level + 1);
        }

        private class Result
        {
            public int Count { get; set; }

            public double Sum { get; set; }

            public double Average => Sum / Count;
        }
    }
}
