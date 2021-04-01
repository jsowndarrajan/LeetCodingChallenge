using April.Problems;
using NUnit.Framework;
using Shared.Models;

namespace April.Tests.Problems
{
    public class PalindromeLinkedListTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void IsPalindrome(ListNode head, bool expected)
        {
            var sut = new PalindromeLinkedList();
            var actual = sut.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1)))),
                true
            },
            new object[]
            {
                new ListNode(1, new ListNode(2)),
                false
            }
        };
    }
}
