using System;
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Shared.Helpers;

namespace February.Problems
{
    public class BinaryTreeRightSideView : IProblem
    {
        public string Title => "Binary Tree Right Side View";

        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3630/";

        public string RightSideViewByUsingQueue(string input)
        {
            try
            {
                var root = DataConverter.ConvertStringArrayToTreeNode(input);
                var result = RightSideViewByUsingQueue(root);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IList<int> RightSideViewByUsingQueue(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue( root );

            while (queue.Count > 0)
            {
                var count = queue.Count;
                TreeNode rightSideNode = null;
                while (count > 0)
                {
                    rightSideNode = queue.Dequeue();

                    if(rightSideNode.Left != null) queue.Enqueue(rightSideNode.Left);
                    if(rightSideNode.Right != null) queue.Enqueue(rightSideNode.Right);

                    count--;
                }
                result.Add(rightSideNode.Value);
            }
            return result;
        }

        public IList<int> RightSideViewByUsingDictionary(TreeNode root)
        {
            var output = new Dictionary<int, int>();
            LevelOrderTraversal(root, output, 0);
            return output.Values.ToList();
        }
        private void LevelOrderTraversal(TreeNode root, Dictionary<int, int> result, int level)
        {
            if (root == null) return;

            if (!result.ContainsKey(level))
            {
                result.Add(level, root.Value);
            }
            else
            {
                result[level] = root.Value;
            }

            LevelOrderTraversal(root.Left, result, level + 1);
            LevelOrderTraversal(root.Right, result, level + 1);
        }
    }
}
