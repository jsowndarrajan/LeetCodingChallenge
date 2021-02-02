using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace February.Problems
{
    public class TrimABinarySearchTree : IProblem
    {
        public string Title => "Trim a Binary Search Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3626/";

        public string TrimBst(string inputNode, string lowerBound, string upperBound)
        {
            try
            {
                var root = DataConverter.ConvertStringArrayToTreeNode(inputNode);
                var low = Convert.ToInt32(lowerBound);
                var high = Convert.ToInt32(upperBound);
                var resultNode = TrimBst(root, low, high);
                return JsonConvert.SerializeObject(TreeHelper.ConstructLevelOrderTree(resultNode));
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TreeNode TrimBst(TreeNode root, int low, int high)
        {
            if (root == null) return null;

            if (root.Value < low)
            {
                return TrimBst(root.Right, low, high);
            }

            if (root.Value > high)
            {
                return TrimBst(root.Left, low, high);
            }

            root.Left = TrimBst(root.Left, low, high);
            root.Right = TrimBst(root.Right, low, high);

            return root;
        }
    }
}
