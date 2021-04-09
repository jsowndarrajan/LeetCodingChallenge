using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class VerifyingAnAlienDictionaryTests
    {
        [TestCase(new[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz", true)]
        [TestCase(new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz", false)]
        [TestCase(new[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz", false)]
        public void IsAlienSorted(string[] words, string order, bool expected)
        {
            var sut = new VerifyingAnAlienDictionary();
            var actual = sut.IsAlienSorted(words, order);
            Assert.AreEqual(expected, actual);
        }
    }
}
