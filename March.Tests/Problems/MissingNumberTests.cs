using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class MissingNumberTests
    {
        [TestCase(new[] { 0 }, 1)]
        [TestCase(new[] { 0, 1 }, 2)]
        [TestCase(new[] { 3, 0, 1 }, 2)]
        [TestCase(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void Compute(int[] input, int expected)
        {
            var sut = new MissingNumber();
            var actual = sut.Compute(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
