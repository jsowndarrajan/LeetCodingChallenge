using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class RemovePalindromicSubsequenceTests
    {
        [TestCase("", 0)]
        [TestCase("a", 1)]
        [TestCase("aa", 1)]
        [TestCase("ab", 2)]
        [TestCase("aba", 1)]
        [TestCase("abb", 2)]
        [TestCase("baabb", 2)]
        [TestCase("babab", 1)]
        [TestCase("bbaabaaa", 2)]
        public void RemovePalindromeSub(string input, int expected)
        {
            var sut = new RemovePalindromicSubsequence();
            var actual = sut.RemovePalindromeSub(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
