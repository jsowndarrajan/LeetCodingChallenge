using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ValidAnagramTests
    {
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        [TestCase("", "car", false)]
        [TestCase("", "", true)]
        public void IsAnagram(string source, string target, bool expected)
        {
            var sut = new ValidAnagram();
            var actual = sut.IsAnagram(source, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
