using System;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace January.Problems
{
    public class FindACorrespondingNodeInAClonedBinaryTree : IProblem
    {
        public string Title => "Find a Corresponding Node of a Binary Tree in a Clone of That Tree";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3590/";
        
        public string GetTargetCopy(string binaryArray, string targetNumber)
        {
            try
            {
                var target = DataConverter.ConvertStringNumberToTargetNode(targetNumber);
                var original = DataConverter.ConvertStringArrayToTreeNode(binaryArray);
                var cloned = DataConverter.ConvertStringArrayToTreeNode(binaryArray, target);

                var node = GetTargetCopy(original, cloned, target);
                return (node == null || node != target)
                    ? Messages.NotFound
                    : Messages.Found;
            }
            catch (Exception)
            {
                return Messages.InvalidInput;
            }
        }

        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || cloned == null) return null;
            if (original.Value == target.Value) return cloned;

            return GetTargetCopy(original.Left, cloned.Left, target)
                   ??
                   GetTargetCopy(original.Right, cloned.Right, target);
        }
    }
}
