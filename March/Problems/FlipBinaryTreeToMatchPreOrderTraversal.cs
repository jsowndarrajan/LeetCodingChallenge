using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;

namespace March.Problems
{
    public class FlipBinaryTreeToMatchPreOrderTraversal : IProblem
    {
        public string Title => "Flip Binary Tree To Match PreOrder Traversal";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/592/week-5-march-29th-march-31st/3689/";

        private int[] _voyage;
        private int _index;
        private List<int> _output;
        public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage)
        {
            _voyage = voyage;
            _index = 0;
            _output = new List<int>();
            Dfs(root);
            return _output;
        }

        private void Dfs(TreeNode root)
        {
            if (root == null) return;

            if (root.Value != _voyage[_index++])
            {
                _output.Clear();
                _output.Add(-1);
                return;
            }

            if (root.Left != null && root.Left.Value != _voyage[_index])
            {
                if (_output.Count == 0 || _output[0] != -1)
                {
                    _output.Add(root.Value);
                    Dfs(root.Right);
                    Dfs(root.Left);
                }
            }
            else
            {
                Dfs(root.Left);
                Dfs(root.Right);
            }
        }
    }
}
