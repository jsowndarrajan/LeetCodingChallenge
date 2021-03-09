using System;
using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace March.Problems
{
    public class AddOneRowToTree : IProblem
    {
        public string Title => "Add One Row to Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3666/";

        public string AddOneRow(string input, string depth, string value)
        {
            try
            {
                if (int.TryParse(depth, out var d) && int.TryParse(value, out var v))
                {
                    var root = DataConverter.ConvertStringArrayToTreeNode(input);
                    var result = AddOneRow(root, v, d);
                    return JsonConvert.SerializeObject(result);
                }
                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TreeNode AddOneRow(TreeNode root, int value, int depth)
        {
            return AddOneRow(root, ref value, ref depth, 1);
        }

        private TreeNode AddOneRow(TreeNode root, ref int value, ref int depth, int currentDepth)
        {
            if (depth == 1)
            {
                return new TreeNode(value, root);
            }

            if (root == null) return null;
            if (depth == currentDepth + 1)
            {
                root.Left = new TreeNode(value, root.Left);
                root.Right = new TreeNode(value, null, root.Right);
            }
            root.Left = AddOneRow(root.Left, ref value, ref depth, currentDepth + 1);
            root.Right = AddOneRow(root.Right, ref value, ref depth, currentDepth + 1);

            return root;
        }
    }
}
