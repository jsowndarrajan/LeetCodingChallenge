using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class DetermineIfTwoStringsAreCloseTests
    {
        [TestCase("abc","bca", true)]
        [TestCase("a","aa", false)]
        [TestCase("cabbba", "abbccc", true)]
        [TestCase("cabbba", "aabbss", false)]
        public void CloseStrings(string word1, string word2, bool expected)
        {
            var sut = new DetermineIfTwoStringsAreClose();
            var actual = sut.CloseStrings(word1, word2);
            Assert.AreEqual(expected, actual);
        }
    }
}
