using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class KthMissingPositiveNumberTests
    {
        private KthMissingPositiveNumber _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new KthMissingPositiveNumber();
        }

        [TestCase(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
        [TestCase(new[] { 1, 2, 3, 4 }, 2, 6)]
        [TestCase(new[] { 5, 6, 7 }, 2, 2)]
        [TestCase(new[] { 5, 6, 7 }, 5, 8)]
        public void FindKthPositive(int[] input, int k, int expected)
        {
            var actual = _sut.FindKthPositive(input, k);
            Assert.AreEqual(actual, expected);
        }
    }
}
