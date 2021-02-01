using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class NumberOf1BitsTests
    {
        [TestCase(11u, 3)]
        [TestCase(4294967293, 31)]
        public void HammingWeight(uint n, int expected)
        {
            var sut = new NumberOf1Bits();
            var actual = sut.HammingWeight(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
