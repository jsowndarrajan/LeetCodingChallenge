using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class SmallestStringWithAGivenNumericValueTests
    {
        [TestCase(3, 27, "aay")]
        [TestCase(5, 73, "aaszz")]
        public void GetSmallestString(int n, int k, string expected)
        {
            var sut = new SmallestStringWithAGivenNumericValue();
            var actual = sut.GetSmallestString(n, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
