using NUnit.Framework;
using Shared.Helpers;
using Shared.Models;

namespace Shared.Tests.Helpers
{
    internal class TreeHelperTests
    {
        [Test, TestCaseSource(nameof(TestCaseTreeNodeSource))]
        public void ShouldConvertStringArrayToTreeNode(string input, TreeNode expected, bool isSymmetric)
        {
            var actual = DataConverter.ConvertStringArrayToTreeNode(input);
            Assert.AreEqual(isSymmetric, TreeHelper.IsSymmetricTree(expected, actual));
        }

        private static readonly object[] TestCaseTreeNodeSource =
        {
            new object[]
            {
                "[1,2,3,null,null,4,5]",
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))),
                true
            },
            new object[]
            {
                "[1,2,3]",
                new TreeNode(1, new TreeNode(2)),
                false
            },
            new object[]
            {
                "[1,2,3,null,4,null,null,null,null,5,6]",
                new TreeNode(1, new TreeNode(2, null, new TreeNode(4, new TreeNode(5), new TreeNode(6))), new TreeNode(3)),
                true
            }
        };

        [Test, TestCaseSource(nameof(TestCaseSymmetricTreeNode))]
        public void TestIsSymmetricTreeNode(TreeNode expected, TreeNode actual, bool isSymmetric)
        {
            Assert.AreEqual(isSymmetric, TreeHelper.IsSymmetricTree(expected, actual));
        }

        private static readonly object[] TestCaseSymmetricTreeNode =
        {
            new object[]
            {
                null,
                null,
                true
            },
            new object[]
            {
                new TreeNode(1),
                new TreeNode(1),
                true
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))),
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))),
                true
            },
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))),
                new TreeNode(2, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))),
                false
            }
        };
    }
}
