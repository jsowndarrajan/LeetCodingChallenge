using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class ReconstructOriginalDigitsFromEnglishTests
    {
        [TestCase("owoztneoer", "012")]
        [TestCase("fviefuro", "45")]
        [TestCase("zeroonetwothreefourfivesixseveneightnine", "0123456789")]
        public void OriginalDigits(string input, string expected)
        {
            var sut = new ReconstructOriginalDigitsFromEnglish();
            var actual = sut.OriginalDigits(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
