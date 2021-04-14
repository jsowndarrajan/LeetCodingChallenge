using April.Problems;
using Newtonsoft.Json;
using NUnit.Framework;
using Shared.Models;

namespace April.Tests.Problems
{
    public class PartitionListTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void Partition(ListNode head, int x, ListNode expected)
        {
            var sut = new PartitionList();
            var actual = sut.Partition(head, x);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2)))))),
                3,
                new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(5)))))),
            }
        };
    }
}
