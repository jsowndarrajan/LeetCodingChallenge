using January.Problems;
using NUnit.Framework;
using Shared.Models;

namespace January.Tests.Problems
{
    public class MergeKSortedListsTests
    {
        [Test]
        public void MergeKLists()
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

            var c2 = new ListNode(2);
            var c9 = new ListNode(9);
            c2.Next = c9;
            var l3 = c2;

            var sut = new MergeKSortedLists();
            var actual = sut.MergeKLists(new[] { l1, l2, l3 });

            var expected = b1;

            Assert.AreEqual(expected, actual);
        }
    }
}
