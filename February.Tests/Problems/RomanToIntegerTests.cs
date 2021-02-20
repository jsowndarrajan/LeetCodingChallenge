using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class RomanToIntegerTests
    {
        [TestCase("I", 1)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        public void RomanToInt(string input, int expected)
        {
            var sut = new RomanToInteger();
            var actual = sut.RomanToInt(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
