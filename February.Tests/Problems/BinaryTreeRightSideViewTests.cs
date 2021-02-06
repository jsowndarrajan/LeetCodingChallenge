using February.Problems;
using NUnit.Framework;
using Shared.Models;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class BinaryTreeRightSideViewTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void RightSideView(TreeNode root, List<int> expected)
        {
            var sut = new BinaryTreeRightSideView();
            var actual1 = sut.RightSideViewByUsingQueue(root);
            var actual2 = sut.RightSideViewByUsingQueue(root);
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new TreeNode(1, new TreeNode(2, null ,new TreeNode(5)), new TreeNode(3, null, new TreeNode(4))), 
                new List<int> {1, 3, 4}
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2)),
                new List<int> {1, 2}
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new List<int> {1, 3}
            },
        };
    }
}
