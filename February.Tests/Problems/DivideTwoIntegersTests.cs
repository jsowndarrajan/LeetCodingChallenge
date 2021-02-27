using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class DivideTwoIntegersTests
    {
        [TestCase(10, 3, 3)]
        [TestCase(7, -3, -2)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(-2147483648, -1, 2147483647)]
        [TestCase(-2147483648, -3, 715827882)]
        public void Divide(int dividend, int divisor, int expected)
        {
            var sut = new DivideTwoIntegers();
            var actual = sut.Divide(dividend, divisor);
            Assert.AreEqual(expected, actual);
        }
    }
}
