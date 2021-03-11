using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class CoinChangeTests
    {
        [TestCase(new[] {1, 2, 5}, 11, 3)]
        [TestCase(new[] {1, 5, 7}, 10, 2)]
        [TestCase(new[] {2, 5, 6}, 1, -1)]
        [TestCase(new[] { 2 }, 3, -1)]
        [TestCase(new[] { 1 }, 0, 0)]
        [TestCase(new[] { 1 }, 1, 1)]
        [TestCase(new[] { 1 }, 2, 2)]
        public void Calculate(int[] coins, int amount, int expected)
        {
            var sut = new CoinChange();
            var actual = sut.Calculate(coins, amount);
            Assert.AreEqual(expected, actual);
        }
    }
}
