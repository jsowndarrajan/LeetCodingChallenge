using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class ReorderedPowerOf2Tests
    {
        [TestCase(1, true)]
        [TestCase(10, false)]
        [TestCase(16, true)]
        [TestCase(24, false)]
        [TestCase(46, true)]
        public void Calculate(int input, bool expected)
        {
            var sut = new ReorderedPowerOf2();
            var actual = sut.Calculate(input);
            Assert.AreEqual(actual, expected);
        }
    }
}
