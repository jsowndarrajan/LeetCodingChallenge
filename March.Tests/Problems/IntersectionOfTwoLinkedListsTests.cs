using March.Problems;
using NUnit.Framework;
using Shared.Models;

namespace March.Tests.Problems
{
    public class IntersectionOfTwoLinkedListsTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void GetIntersectionNode(ListNode headA, ListNode headB, ListNode expected)
        {
            var sut = new IntersectionOfTwoLinkedLists();
            var actual = sut.GetIntersectionNode(headA, headB);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new ListNode(4, new ListNode(1, node8)),
                new ListNode(5, new ListNode(6, new ListNode(1, node8))),
                node8
            },
            new object[]
            {
                new ListNode(1, new ListNode(9, new ListNode(1, node2))),
                new ListNode(3, node2),
                node2
            },
            new object[]
            {
                new ListNode(2, new ListNode(6, new ListNode(4))),
                new ListNode(1, new ListNode(5)),
                null
            }
        };

        private static readonly ListNode node8 = new ListNode(8, new ListNode(4, new ListNode(5)));
        private static readonly ListNode node2 = new ListNode(2, new ListNode(4));
    }
}
