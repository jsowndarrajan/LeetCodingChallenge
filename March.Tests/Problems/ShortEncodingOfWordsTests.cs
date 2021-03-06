using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class ShortEncodingOfWordsTests
    {
        [TestCase(new[] { "time", "me", "bell" }, 10)]
        [TestCase(new[] { "t" }, 2)]
        [TestCase(new[] { "me", "time" }, 5)]
        [TestCase(new[] { "feipyxx", "e" }, 10)]
        public void MinimumLengthEncodingByUsingSet(string[] words, int expected)
        {
            var sut = new ShortEncodingOfWords();
            var actual = sut.MinimumLengthEncodingByUsingSet(words);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { "time", "me", "bell" }, 10)]
        [TestCase(new[] { "t" }, 2)]
        [TestCase(new[] { "me", "time" }, 5)]
        [TestCase(new[] { "feipyxx", "e" }, 10)]
        [TestCase(new[] { "time", "time", "time" }, 5)]
        public void MinimumLengthEncoding(string[] words, int expected)
        {
            var sut = new ShortEncodingOfWords();
            var actual = sut.MinimumLengthEncodingByUsingTrie(words);
            Assert.AreEqual(expected, actual);
        }
    }
}
