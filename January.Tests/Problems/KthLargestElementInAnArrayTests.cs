using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class KthLargestElementInAnArrayTests
    {
        private KthLargestElementInAnArray _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new KthLargestElementInAnArray();
        }

        [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
        [TestCase(new[] {3,2,3,1,2,4,5,5,6,7,7,8,2,3,1,1,1,10,11,5,6,2,4,7,8,5,6}, 20 , 2)]
        public void FindKthLargestByUsingHeap(int[] nums, int k, int expected)
        {
            var actual = _sut.FindKthLargestByUsingHeap(nums, k);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
        public void FindKthLargestByUsingArray(int[] nums, int k, int expected)
        {
            var actual = _sut.FindKthLargestByUsingArray(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
