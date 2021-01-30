using System;
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Shared.Helpers;

namespace January.Problems
{
    public class VerticalOrderTraversalOfABinaryTree : IProblem
    {
        public string Title => "Vertical Order Traversal of a Binary Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/583/week-5-january-29th-january-31st/3621/";


        public string VerticalTraversal(string input)
        {
            try
            {
                var root = DataConverter.ConvertStringArrayToTreeNode(input);
                var result = VerticalTraversal(root);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var result = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
            VerticalOrderTraversal(root, result, 0, 0);

            var output = new List<IList<int>>();
            foreach (var kp in result)
            {
                var subResult = new List<int>();
                foreach (var item in kp.Value)
                {
                    subResult.AddRange(item.Value);
                }
                output.Add(subResult);
            }
            return output;
        }

        private void VerticalOrderTraversal(TreeNode root, SortedDictionary<int, SortedDictionary<int, List<int>>> result, int column, int row)
        {
            if (root == null) return;

            if (result.ContainsKey(column))
            {
                if (result[column].ContainsKey(row))
                {
                    result[column][row].Add(root.Value);
                    result[column][row].Sort();
                }
                else
                {
                    result[column].Add(row, new List<int> {root.Value});
                }
            }
            else
            {
                result[column] = new SortedDictionary<int, List<int>> {{row, new List<int>()}};
                result[column][row].Add(root.Value);
            }

            VerticalOrderTraversal(root.Left, result, column - 1, row + 1);
            VerticalOrderTraversal(root.Right, result, column + 1, row + 1);
        }
    }
}
