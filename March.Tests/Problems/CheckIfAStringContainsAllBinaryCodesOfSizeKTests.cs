using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class CheckIfAStringContainsAllBinaryCodesOfSizeKTests
    {
        [TestCase("00110110", 2, true)]
        [TestCase("00110", 2, true)]
        [TestCase("0110", 2, false)]
        [TestCase("0000000001011100", 4, false)]
        public void HasAllCodes(string input, int k, bool expected)
        {
            var sut = new CheckIfAStringContainsAllBinaryCodesOfSizeK();
            var actual = sut.HasAllCodes(input, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
