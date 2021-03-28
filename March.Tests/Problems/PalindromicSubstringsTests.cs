using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class PalindromicSubstringsTests
    {
        [TestCase("abc", 3)]
        [TestCase("aaa", 6)]
        [TestCase("aaaaa", 15)]
        public void CountSubstrings(string input, int expected)
        {
            var sut = new PalindromicSubstrings();
            var actual = sut.CountSubstrings(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
