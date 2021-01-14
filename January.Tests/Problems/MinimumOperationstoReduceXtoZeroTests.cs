using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class MinimumOperationsToReduceXToZeroTests
    {
        private MinimumOperationsToReduceXToZero _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MinimumOperationsToReduceXToZero();
        }

        [TestCase(new[] {1,1,4,2,3}, 5, 2)]
        [TestCase(new[] {5,6,7,8,9}, 4, -1)]
        [TestCase(new[] {3,2,20,1,1,3}, 10, 5)]
        public void MinOperations(int[] nums, int x, int expected)
        {
            var actual = _sut.MinOperations(nums, x);
            Assert.AreEqual(expected, actual);
        }
    }
}
