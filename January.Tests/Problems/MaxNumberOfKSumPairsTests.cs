using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class MaxNumberOfKSumPairsTests
    {
        private MaxNumberOfKSumPairs _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MaxNumberOfKSumPairs();
        }

        [TestCase(new[] {3, 1, 3, 4, 3, 2}, 6, 2)]
        [TestCase(new[] {1,2,3,4,5}, 5, 2)]
        public void MaxOperationsByUsingArraySort(int[] nums, int k, int expected)
        {
            var actual = _sut.MaxOperationsByUsingArraySort(nums, k);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 1, 3, 4, 3, 2 }, 6, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5, 2)]
        public void MaxOperationsByUsingDictionary1(int[] nums, int k, int expected)
        {
            var actual = _sut.MaxOperationsByUsingDictionary1(nums, k);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 1, 3, 4, 3, 2 }, 6, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5, 2)]
        public void MaxOperationsByUsingDictionary2(int[] nums, int k, int expected)
        {
            var actual = _sut.MaxOperationsByUsingDictionary2(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
