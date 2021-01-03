using January.Problems;
using NUnit.Framework;
using Shared.Models;

namespace January.Tests.Problems
{
    public class FindACorrespondingNodeInAClonedBinaryTreeTests
    {
        private FindACorrespondingNodeInAClonedBinaryTree _sut;
        private static readonly TreeNode TargetNode = new TreeNode(3);

        [SetUp]
        public void Setup()
        {
            _sut = new FindACorrespondingNodeInAClonedBinaryTree();
        }

        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void GetTargetCopyTest(TreeNode original, TreeNode cloned, TreeNode target)
        {
            var actual = _sut.GetTargetCopy(original, cloned, target);
            Assert.That(actual, Is.EqualTo(target));
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new TreeNode(1, new TreeNode(2), TargetNode),
                TargetNode
            }
        };
    }
}
