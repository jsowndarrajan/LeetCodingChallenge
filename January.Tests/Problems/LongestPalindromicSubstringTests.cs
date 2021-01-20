using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class LongestPalindromicSubstringTests
    {
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("ab", "a")]
        [TestCase("aba", "aba")]
        [TestCase("ccc", "ccc")]
        [TestCase("cbbd", "bb")]
        [TestCase("babad", "bab")]
        [TestCase("eeabaeef", "eeabaee")]
        [TestCase("abdeeabaeefefg", "eeabaee")]
        [TestCase("aacabdkacaa", "aca")]
        [TestCase("bananas", "anana")]
        [TestCase("ababababababa", "ababababababa")]
        public void LongestPalindrome(string input, string expected)
        {
            var sut = new LongestPalindromicSubstring();
            var actual = sut.LongestPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
