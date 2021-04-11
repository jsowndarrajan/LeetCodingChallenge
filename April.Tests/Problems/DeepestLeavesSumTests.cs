using April.Problems;
using NUnit.Framework;
using Shared.Models;

namespace April.Tests.Problems
{
    public class DeepestLeavesSumTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void FindSumUsingBfs(TreeNode root, int expected)
        {
            var sut = new DeepestLeavesSum();
            var actual = sut.FindSumUsingBfs(root);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new[]
        {
            new object[]
            {
                new TreeNode(1,
                    new TreeNode(2,
                        new TreeNode(4,
                            new TreeNode(7)),
                        new TreeNode(5)),
                    new TreeNode(3,
                        null,
                        new TreeNode(6,
                            null,
                            new TreeNode(8)))),
                15
            }
        };
    }
}
