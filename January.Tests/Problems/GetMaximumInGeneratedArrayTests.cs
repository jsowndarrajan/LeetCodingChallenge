using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class GetMaximumInGeneratedArrayTests
    {
        private GetMaximumInGeneratedArray _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new GetMaximumInGeneratedArray();
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 3)]
        [TestCase(7, 3)]
        public void GetMaximumGenerated(int n, int expected)
        {
            var actual = _sut.GetMaximumGenerated(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
