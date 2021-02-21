using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class BrokenCalculatorTests
    {
        [TestCase(2, 3, 2)]
        [TestCase(5, 8, 2)]
        [TestCase(3, 10, 3)]
        [TestCase(1024, 1, 1023)]
        public void BrokenCalc(int x, int y, int expected)
        {
            var sut = new BrokenCalculator();
            var actual = sut.BrokenCalc(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
