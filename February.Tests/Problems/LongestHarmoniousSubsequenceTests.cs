using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class LongestHarmoniousSubsequenceTests
    {
        [TestCase(new[] { 1, 3, 2, 2, 5, 2, 3, 7 }, 5)]
        [TestCase(new[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new[] { 1, 1, 1, 1 }, 0)]
        public void FindLHS(int[] input, int expected)
        {
            var sut = new LongestHarmoniousSubsequence();
            var actual = sut.FindLHS(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
