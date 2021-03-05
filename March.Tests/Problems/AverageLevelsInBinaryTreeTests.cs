using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using March.Problems;
using NUnit.Framework;
using Shared.Models;

namespace March.Tests.Problems
{
    public class AverageLevelsInBinaryTreeTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void AverageOfLevelsUsingStack(TreeNode root, List<double> expected)
        {
            var sut = new AverageLevelsInBinaryTree();
            var actual = sut.AverageOfLevelsUsingStack(root);
            Assert.AreEqual(expected, actual);
        }


        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void AverageOfLevelsByUsingDictionary(TreeNode root, List<double> expected)
        {
            var sut = new AverageLevelsInBinaryTree();
            var actual = sut.AverageOfLevelsByUsingDictionary(root);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), 
                new List<double> { 3, 14.5, 11 }, 
            },
            new object[]
            {
                new TreeNode(3),
                new List<double> { 3 },
            },
            new object[]
            {
                new TreeNode(3, new TreeNode(-1), new TreeNode(-2)),
                new List<double> { 3, -1.5 },
            },
        };
    }
}
