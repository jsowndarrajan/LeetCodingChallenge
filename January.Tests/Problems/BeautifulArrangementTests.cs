using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class BeautifulArrangementTests
    {
        private BeautifulArrangement _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new BeautifulArrangement();
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 8)]
        [TestCase(5, 10)]
        [TestCase(6, 36)]
        [TestCase(7, 41)]
        [TestCase(8, 132)]
        [TestCase(9, 250)]
        [TestCase(10, 700)]
        [TestCase(11, 750)]
        [TestCase(12, 4010)]
        [TestCase(13, 4237)]
        [TestCase(14, 10680)]
        [TestCase(15, 24679)]
        public void CanFormArray(int n, int expected)
        {
            var actual = _sut.CountArrangement(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
