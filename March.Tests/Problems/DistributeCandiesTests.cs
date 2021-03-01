using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class DistributeCandiesTests
    {
        [TestCase(new[] {1, 1}, 1)]
        [TestCase(new[] {1, 1, 2, 3}, 2)]
        [TestCase(new[] {1, 1, 2, 3, 2, 3}, 3)]
        [TestCase(new[] {1, 1, 1, 1}, 1)]
        public void Calculate(int[] candyType, int expected)
        {
            var sut = new DistributeCandies();
            var actual = sut.Calculate(candyType);
            Assert.AreEqual(expected, actual);
        }
    }
}
