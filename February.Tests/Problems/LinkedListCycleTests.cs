using February.Problems;
using NUnit.Framework;
using Shared.Models;

namespace February.Tests.Problems
{
    public class LinkedListCycleTests
    {
        [Test]
        public void HasCycle1()
        {
            var n1 = new ListNode(1);
            n1.Next = n1;

            var sut = new LinkedListCycle();
            var actual = sut.HasCycle(n1);

            Assert.True(actual);
        }

        [Test]
        public void HasCycle2()
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            n1.Next = n2;
            n2.Next = n3;

            var sut = new LinkedListCycle();
            var actual = sut.HasCycle(n1);

            Assert.False(actual);
        }

        [Test]
        public void HasCycle3()
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            var n5 = new ListNode(5);
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n2;

            var sut = new LinkedListCycle();
            var actual = sut.HasCycle(n1);

            Assert.True(actual);
        }
    }
}
