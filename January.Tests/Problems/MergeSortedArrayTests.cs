using NUnit.Framework;

namespace January.Tests.Problems
{
    public class MergeSortedArrayTests
    {
        private MergeSortedArray _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MergeSortedArray();
        }

        [TestCase(new[] { 0 }, 0, new[] { 2 }, 1, new[] { 2 })]
        [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
        public void Merge(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            _sut.Merge(nums1, m, nums2, n);
            Assert.AreEqual(expected, nums1);
        }
    }
}
