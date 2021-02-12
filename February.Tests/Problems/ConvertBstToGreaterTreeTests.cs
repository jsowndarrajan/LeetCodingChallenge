using February.Problems;
using NUnit.Framework;
using Shared.Helpers;
using Shared.Models;

namespace February.Tests.Problems
{
    public class ConvertBstToGreaterTreeTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void ConvertBst1(TreeNode input, TreeNode expected)
        {
            var sut = new ConvertBstToGreaterTree();
            var actual = sut.ConvertBst1(input);
            Assert.IsTrue(TreeHelper.IsSymmetricTree(expected, actual));
        }

        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void ConvertBst2(TreeNode input, TreeNode expected)
        {
            var sut = new ConvertBstToGreaterTree();
            var actual = sut.ConvertBst2(input);
            Assert.IsTrue(TreeHelper.IsSymmetricTree(expected, actual));
        }

        private static object[] TestCaseSource => new object[]
        {
            new[]
            {
                new TreeNode(1),
                new TreeNode(1)
            },
            new[]
            {
                new TreeNode(1, null, new TreeNode(3)),
                new TreeNode(4, null, new TreeNode(3)),
            },
            new[]
            {
                new TreeNode(1, new TreeNode(0), new TreeNode(3)),
                new TreeNode(4, new TreeNode(4), new TreeNode(3)),
            },
            new[]
            {
                new TreeNode(4,
                    new TreeNode(1,
                        new TreeNode(0),
                        new TreeNode(2,
                            null,
                            new TreeNode(3))),
                    new TreeNode(6,
                        new TreeNode(5),
                        new TreeNode(7,
                            null,
                            new TreeNode(8)))),
                new TreeNode(30,
                    new TreeNode(36,
                        new TreeNode(36),
                        new TreeNode(35,
                            null,
                            new TreeNode(33))),
                    new TreeNode(21,
                        new TreeNode(26),
                        new TreeNode(15,
                            null,
                            new TreeNode(8)))),
            },
        };
}
}
