using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace February.Problems
{
    public class ConvertBstToGreaterTree : IProblem
    {
        public string Title => "Convert BST to Greater Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3634/";

        public string ConvertBst(string input)
        {
            try
            {
                var root = DataConverter.ConvertStringArrayToTreeNode(input);
                var greaterTree = ConvertBst1(root);
                return JsonConvert.SerializeObject(greaterTree);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TreeNode ConvertBst1(TreeNode root)
        {
            var resultNodes = new List<TreeNode>();
            InOrder(root, resultNodes);

            var result = 0;
            foreach (var node in resultNodes)
            {
                if (node is not null)
                {
                    node.Value += result;
                    result = node.Value;
                }
            }
            return root;
        }

        public TreeNode InOrder(TreeNode root, List<TreeNode> resultNodes)
        {
            if (root != null)
            {
                resultNodes.Add(InOrder(root.Right, resultNodes));
                resultNodes.Add(root);
                resultNodes.Add(InOrder(root.Left, resultNodes));
            }
            return null;
        }


        private TreeNode _previous;

        public TreeNode ConvertBst2(TreeNode root)
        {
            _previous = null;
            Helper(root);
            return root;
        }

        private void Helper(TreeNode root)
        {
            if(root == null) return;

            Helper(root.Right);

            if (_previous != null)
            {
                root.Value += _previous.Value;
            }

            _previous = root;

            Helper(root.Left);
        }
    }
}
