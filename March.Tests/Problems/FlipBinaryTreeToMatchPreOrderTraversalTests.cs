using NUnit.Framework;
using Shared.Models;
using System.Collections.Generic;
using March.Problems;

namespace March.Tests.Problems
{
    public class FlipBinaryTreeToMatchPreOrderTraversalTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void FlipMatchVoyage(TreeNode root, int[] voyage, IList<int> expected)
        {
            var sut = new FlipBinaryTreeToMatchPreOrderTraversal();
            var actual = sut.FlipMatchVoyage(root, voyage);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new TreeNode(1, new TreeNode(2)), 
                new[] {2, 1},
                new List<int> { -1 }, 
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new[] {1, 2, 3},
                new List<int>(),
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new[] {1, 3, 2},
                new List<int> { 1 },
            }
        };
    }
}
