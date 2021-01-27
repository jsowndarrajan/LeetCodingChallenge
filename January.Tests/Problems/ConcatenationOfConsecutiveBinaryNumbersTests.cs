using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class ConcatenationOfConsecutiveBinaryNumbersTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 6)]
        [TestCase(3, 27)]
        [TestCase(12, 505379714)]
        public void ConcatenatedBinary(int n, int expected)
        {
            var sut = new ConcatenationOfConsecutiveBinaryNumbers();
            var actual = sut.ConcatenatedBinary(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
