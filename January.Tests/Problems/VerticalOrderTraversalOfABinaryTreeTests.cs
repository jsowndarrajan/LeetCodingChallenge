using January.Problems;
using NUnit.Framework;
using Shared.Models;
using System.Collections.Generic;

namespace January.Tests.Problems
{
    internal class VerticalOrderTraversalOfABinaryTreeTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void VerticalTraversal(TreeNode rootNode, IList<IList<int>> expected)
        {
            var sut = new VerticalOrderTraversalOfABinaryTree();
            var actual = sut.VerticalTraversal(rootNode);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new TreeNode(3,
                    new TreeNode(9),
                    new TreeNode(20,
                        new TreeNode(15),
                        new TreeNode(7))), 
                new List<IList<int>>
                {
                    new List<int> {9},
                    new List<int> {3, 15},
                    new List<int> {20},
                    new List<int> {7}
                }, 
            },
            new object[]
            {
                new TreeNode(1,
                    new TreeNode(2,
                        new TreeNode(4),
                        new TreeNode(5)),
                    new TreeNode(3,
                        new TreeNode(6),
                            new TreeNode(7))),
                new List<IList<int>>
                {
                    new List<int> {4},
                    new List<int> {2},
                    new List<int> {1,5,6},
                    new List<int> {3},
                    new List<int> {7}
                }
            },
            new object[]
            {
                new TreeNode(1,
                    new TreeNode(2,
                        new TreeNode(4),
                        new TreeNode(6)),
                    new TreeNode(3,
                        new TreeNode(5),
                        new TreeNode(7))),
                new List<IList<int>>
                {
                    new List<int> {4},
                    new List<int> {2},
                    new List<int> {1,5,6},
                    new List<int> {3},
                    new List<int> {7}
                }
            }

        };
    }
}
