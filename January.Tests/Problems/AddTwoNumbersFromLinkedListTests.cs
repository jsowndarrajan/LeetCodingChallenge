using January.Problems;
using NUnit.Framework;
using Shared.Models;

namespace January.Tests.Problems
{
    public class AddTwoNumbersFromLinkedListTests
    {
        private AddTwoNumbersFromLinkedList _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new AddTwoNumbersFromLinkedList();
        }

        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void AddTwoNumbers(ListNode l1, ListNode l2, ListNode expected)
        {
            var actual = _sut.AddTwoNumbers(l1, l2);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new ListNode(2),
                new ListNode(3),
                new ListNode(5)
            },
            new object[]
            {
                new ListNode(2, new ListNode(4, new ListNode(3))),
                new ListNode(5, new ListNode(6, new ListNode(4))),
                new ListNode(7, new ListNode(0, new ListNode(8)))
            },
            new object[]
            {
                new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9))))))),
                new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9)))),
                new ListNode(8,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(0,
                                new ListNode(0,
                                    new ListNode(0,
                                        new ListNode(1)))))))),
            }
        };
    }
}
