using March.Problems;
using NUnit.Framework;
using System.Linq;

namespace March.Tests.Problems
{
    public class WordSubsetsTests
    {
        [TestCase(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "o" }, new[] { "facebook", "google", "leetcode" })]
        [TestCase(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "l", "e" }, new[] { "apple", "google", "leetcode" })]
        [TestCase(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "oo" }, new[] { "facebook", "google" })]
        [TestCase(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "lo", "eo" }, new[] { "google", "leetcode" })]
        public void Calculate(string[] A, string[] B, string[] expected)
        {
            var sut = new WordSubsets();
            var actual = sut.Calculate(A, B);
            Assert.AreEqual(expected, actual.ToArray());
        }
    }
}
