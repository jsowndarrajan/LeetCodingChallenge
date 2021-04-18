using April.Problems;
using Newtonsoft.Json;
using NUnit.Framework;
using Shared.Models;

namespace April.Tests.Problems
{
    public class RemoveNthNodeFromEndOfListTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void RemoveNthFromEnd(ListNode head, int n, ListNode expected)
        {
            var sut = new RemoveNthNodeFromEndOfList();
            var actual = sut.RemoveNthFromEnd(head, n);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new ListNode(1),
                1,
                null
            },
            new object[]
            {
                new ListNode(1, new ListNode(2)),
                2,
                new ListNode(2)
            },
            new object[]
            {
                new ListNode(1, new ListNode(2)),
                1,
                new ListNode(1)
            },
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                2,
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5)))),
            }
        };
    }
}
