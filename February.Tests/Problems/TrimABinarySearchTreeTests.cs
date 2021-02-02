using February.Problems;
using NUnit.Framework;
using Shared.Models;

namespace February.Tests.Problems
{
    public class TrimABinarySearchTreeTests
    {
        [Test]
        public void TrimBst1()
        {
            var t1 = new TreeNode(1);
            var low = 0;
            var high = 2;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t1, low, high);
            Assert.AreEqual(t1, actual);
        }

        [Test]
        public void TrimBst2()
        {
            var t1 = new TreeNode(1);
            var low = 2;
            var high = 4;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t1, low, high);
            Assert.IsNull(actual);
        }

        [Test]
        public void TrimBst3()
        {
            var t1 = new TreeNode(5);
            var low = 2;
            var high = 4;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t1, low, high);
            Assert.IsNull(actual);
        }

        [Test]
        public void TrimBst4()
        {
            var t0 = new TreeNode(0);
            var t1 = new TreeNode(1);
            var t2 = new TreeNode(2);

            t1.Left = t0;
            t1.Right = t2;

            var low = 1;
            var high = 2;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t1, low, high);
            Assert.AreEqual(actual, t1);
        }

        [Test]
        public void TrimBst5()
        {
            var t1 = new TreeNode(1);
            var t2 = new TreeNode(2);
            var t3 = new TreeNode(3);
            var t4 = new TreeNode(4);

            t3.Left = t1;
            t3.Right = t4;
            t1.Right = t2;

            var low = 3;
            var high = 4;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t3, low, high);
            Assert.AreEqual(actual, t3);
        }

        [Test]
        public void TrimBst6()
        {
            var t1 = new TreeNode(1);
            var t2 = new TreeNode(2);
            var t3 = new TreeNode(3);
            var t4 = new TreeNode(4);

            t3.Left = t1;
            t3.Right = t4;
            t1.Right = t2;

            var low = 1;
            var high = 2;
            var sut = new TrimABinarySearchTree();
            var actual = sut.TrimBst(t3, low, high);
            Assert.AreEqual(actual, t1);
        }
    }
}
