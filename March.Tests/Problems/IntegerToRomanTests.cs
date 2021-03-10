using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class IntegerToRomanTests
    {
        [TestCase(1, "I")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(70, "LXX")]
        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(600, "DC")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(2000, "MM")]
        public void IntToRoman(int num, string expected)
        {
            var sut = new IntegerToRoman();
            var actual = sut.IntToRoman(num);
            Assert.AreEqual(expected, actual);
        }
    }
}
