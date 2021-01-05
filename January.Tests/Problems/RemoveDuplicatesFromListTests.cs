using January.Problems;
using NUnit.Framework;
using Shared.Models;

namespace January.Tests.Problems
{
    public class RemoveDuplicatesFromListTests
    {
        private RemoveDuplicatesFromList _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new RemoveDuplicatesFromList();
        }

        [Test, TestCaseSource(nameof(_testCaseSource))]
        public void DeleteDuplicatesTest(ListNode input, ListNode expected)
        {
            var actual = _sut.DeleteDuplicates(input);
            Assert.AreEqual(expected?.ToString(), actual?.ToString());
        }

        private static readonly object[] _testCaseSource =
        {
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(2))),
                new ListNode(1),
            },
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3)))),
                new ListNode(1, new ListNode(3)),
            },
            new object[]
            {
                new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3))))),
                new ListNode(2, new ListNode(3)),
            },
            new object[]
            {
                new ListNode(1),
                new ListNode(1)
            },
            new object[]
            {
                new ListNode(1, new ListNode(1)),
                null
            },
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5))))))),
                new ListNode(1, new ListNode(2, new ListNode(5))),
            },
        };
    }
}
