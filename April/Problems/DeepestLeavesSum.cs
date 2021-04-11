using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;

namespace April.Problems
{
    public class DeepestLeavesSum : IProblem
    {
        public string Title => "Deepest Leaves Sum";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3704/";

        public int FindSumUsingBfs(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var output = 0;
            while (queue.Count > 0)
            {
                var count = queue.Count;
                output = 0;
                while (count > 0)
                {
                    var current = queue.Dequeue();
                    output += current.Value;

                    if(current.Left != null) queue.Enqueue(current.Left);
                    if(current.Right != null) queue.Enqueue(current.Right);

                    count--;
                }
            }

            return output;
        }
    }
}
