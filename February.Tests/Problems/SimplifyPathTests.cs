using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class SimplifyPathTests
    {
        [TestCase("/home/", "/home")]
        [TestCase("/../", "/")]
        [TestCase("/home//foo/", "/home/foo")]
        [TestCase("/a/./b/../../c/", "/c")]
        public void GenerateCanonicalPath(string input, string expected)
        {
            var sut = new SimplifyPath();
            var actual = sut.GenerateCanonicalPath(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToCanonicalPathFromFilledStack()
        {
            var commands = new Stack<string>();
            commands.Push("a");
            commands.Push("c");
            commands.Push("d");
            var sut = new SimplifyPath();
            var actual = sut.ConvertToCanonicalPath(commands);
            Assert.AreEqual("/a/c/d", actual);
        }

        [Test]
        public void ConvertToCanonicalPathFromEmptyStack()
        {
            var commands = new Stack<string>();
            var sut = new SimplifyPath();
            var actual = sut.ConvertToCanonicalPath(commands);
            Assert.AreEqual("/", actual);
        }
    }
}
