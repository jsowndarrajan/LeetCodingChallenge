using January.Problems;
using NUnit.Framework;
using Shared.Models;

namespace January.Tests.Problems
{
    public class MergeTwoSortedListsTests
    {

        private MergeTwoSortedLists _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MergeTwoSortedLists();
        }

        [Test]
        public void MergeTwoLists()
        {
            var a5 = new ListNode(5);
            var a6 = new ListNode(6);
            var a7 = new ListNode(7);
            a5.Next = a6;
            a6.Next = a7;
            var l1 = a5;

            var b1 = new ListNode(1);
            var b9 = new ListNode(9);
            var b10 = new ListNode(10);
            var b20 = new ListNode(20);
            b1.Next = b9;
            b9.Next = b10;
            b10.Next = b20;
            var l2 = b1;

            var actual = _sut.MergeTwoLists(l1, l2);

            var expected = b1;
            b1.Next = a5;
            a5.Next = a6;
            a6.Next = a7;
            a7.Next = b9;
            b9.Next = b10;
            b10.Next = b20;

            Assert.AreEqual(expected, actual);
        }
    }
}
