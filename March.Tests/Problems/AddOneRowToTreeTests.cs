using March.Problems;
using NUnit.Framework;
using Shared.Helpers;
using Shared.Models;

namespace March.Tests.Problems
{
    public class AddOneRowToTreeTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void AddOneRow(TreeNode root, int value, int depth, TreeNode expected)
        {
            var sut = new AddOneRowToTree();
            var actual = sut.AddOneRow(root, value, depth);
            Assert.IsTrue(TreeHelper.IsSymmetricTree(expected, actual));
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(1)), new TreeNode(6, new TreeNode(5))), 
                1,
                2,
                new TreeNode(4, new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(1))), new TreeNode(1, null, new TreeNode(6, new TreeNode(5)))),
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3)),
                5,
                4,
                new TreeNode(1, new TreeNode(2, new TreeNode(4, new TreeNode(5), new TreeNode(5))), new TreeNode(3)),
            }
        };
    }
}
