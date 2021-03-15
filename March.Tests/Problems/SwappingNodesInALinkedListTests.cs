using March.Problems;
using NUnit.Framework;
using Shared.Models;

namespace March.Tests.Problems
{
    public class SwappingNodesInALinkedListTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void SwapNodes(ListNode head, int k, ListNode expected)
        {
            var sut = new SwappingNodesInALinkedList();
            var actual = sut.SwapNodes(head, k);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                2,
                new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))))
            },
            new object[]
            {
                new ListNode(1),
                1,
                new ListNode(1),
            },
            new object[]
            {
                new ListNode(7, new ListNode(9, new ListNode(6, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(3, new ListNode(0, new ListNode(9, new ListNode(5)))))))))),
                5,
                new ListNode(7, new ListNode(9, new ListNode(6, new ListNode(6, new ListNode(8, new ListNode(7, new ListNode(3, new ListNode(0, new ListNode(9, new ListNode(5)))))))))),
            },
        };
    }
}
